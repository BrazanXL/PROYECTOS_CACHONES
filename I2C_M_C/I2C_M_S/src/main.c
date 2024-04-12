#include <stdio.h>
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "driver/i2c.h"
#include "esp_log.h"
#include "lcd_i2c.h"  // Librería para el uso del LCD con módulo I2C PCF8574

#define SLAVE_RX_BUF        1024
#define SLAVE_ADDR_LED      0x32
#define SLAVE_ADDR_LCD      0x3F
#define SLAVE_SCL           22
#define SLAVE_SDA           21

void i2c_slave_init() {
    i2c_config_t i2c_slave_config = {
        .mode = I2C_MODE_SLAVE,
        .sda_io_num = SLAVE_SDA,
        .sda_pullup_en = GPIO_PULLUP_ENABLE,
        .scl_io_num = SLAVE_SCL,
        .scl_pullup_en = GPIO_PULLUP_ENABLE,
        .slave.addr_10bit_en = 0,
        .slave.slave_addr = SLAVE_ADDR_LED, // Este ESP32 está configurado como Slave para los LEDs
    };
    ESP_ERROR_CHECK(i2c_param_config(I2C_NUM_0, &i2c_slave_config));
    ESP_ERROR_CHECK(i2c_driver_install(I2C_NUM_0, i2c_slave_config.mode, SLAVE_RX_BUF*2, 0, 0));
}

void app_main() {
    i2c_slave_init();
    lcd_init(); // Inicialización de la pantalla LCD
    
    size_t size_led = 3; // El tamaño del comando de control de LEDs es de 3 bytes
    size_t size_lcd = 4; // El tamaño del comando para la pantalla LCD es de 4 bytes
    uint8_t data_led[3] = {0}; // Buffer para almacenar el comando de control de LEDs
    uint8_t data_lcd[4] = {0}; // Buffer para almacenar el comando para la pantalla LCD
    
    while(1) {
        // Recibe el comando para controlar los LEDs desde el Maestro
        int len_led = i2c_slave_read_buffer(I2C_NUM_0, data_led, size_led, portMAX_DELAY);
        if(len_led > 0) {
            // Interpreta el comando y controla los LEDs según sea necesario
            printf("Comando de control de LEDs recibido desde el Maestro: %d, %d, %d\n", data_led[0], data_led[1], data_led[2]);
            // Aquí puedes agregar la lógica para controlar los LEDs
        }
        
        // Recibe el comando para controlar la pantalla LCD desde el Maestro
        int len_lcd = i2c_slave_read_buffer(I2C_NUM_0, data_lcd, size_lcd, portMAX_DELAY);
        if(len_lcd > 0) {
            // Interpreta el comando y controla la pantalla LCD según sea necesario
            printf("Comando para la pantalla LCD recibido desde el Maestro: %d, %d, %d, %d\n", data_lcd[0], data_lcd[1], data_lcd[2], data_lcd[3]);
            // Aquí puedes agregar la lógica para controlar la pantalla LCD
            // Se pone la pantalla LCD en blanco cada nuevo ciclo
        lcd_clear(); 
        
        // Se coloca el cursor en la posición (0, 0) de la pantalla (fila, columna)
        lcd_cursor(0, 0); 

        // Se escribe el texto en pantalla
        lcd_write_string("Estado de los LEDs:"); 
        
        // Leer el estado de los LEDs desde el Maestro a través del bus I2C
        uint8_t led_state[3] = {0}; // Supongamos que el estado de los LEDs se envía como 3 bytes
        i2c_master_read_from_device(I2C_NUM_0, SLAVE_ADDR_LED, led_state, sizeof(led_state), 100/portTICK_PERIOD_MS);
        
        // Mostrar el estado de los LEDs en la pantalla LCD
        lcd_cursor(1, 0); // Segunda línea de la pantalla LCD
        lcd_write_string("LED1: ");
        lcd_write_char(led_state[0] ? '1' : '0');
        lcd_write_string(" LED2: ");
        lcd_write_char(led_state[1] ? '1' : '0');
        lcd_write_string(" LED3: ");
        lcd_write_char(led_state[2] ? '1' : '0');
        
        vTaskDelay(3000/portTICK_PERIOD_MS); // Espera antes de actualizar la pantalla LCD
        }
    }
}
