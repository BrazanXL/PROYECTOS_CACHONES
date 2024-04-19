#include <stdio.h>
#include <string.h>
#include "driver/gpio.h"
#include "driver/uart.h"
#include "driver/i2c.h"
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "freertos/queue.h"
#include "utilities1.h"
#include "esp_intr_alloc.h"
#include "esp_log.h"
#include "lcd_i2c.h"

#define BUF_SIZE 1024
#define SLAVE_ADDR 0x32
#define MASTER_PORT I2C_NUM_0
#define MASTER_SDA 21
#define MASTER_SCL 22
#define MASTER_FREQ_HZ 100000
#define UART_INSTANCE_0 UART_NUM_0

static QueueHandle_t uart0_queue;

static void uart_interrupt_task(void *params);

void i2c_master_init() {
    i2c_config_t i2c_master_config = {
        .mode = I2C_MODE_MASTER,
        .sda_io_num = MASTER_SDA,
        .scl_io_num = MASTER_SCL,
        .sda_pullup_en = GPIO_PULLUP_ENABLE,
        .scl_pullup_en = GPIO_PULLUP_ENABLE,
        .master.clk_speed = MASTER_FREQ_HZ,
    };
    ESP_ERROR_CHECK(i2c_param_config(MASTER_PORT, &i2c_master_config));
    ESP_ERROR_CHECK(i2c_driver_install(MASTER_PORT, i2c_master_config.mode, 0, 0, 0));
}

void app_main() {
    i2c_master_init();
    uart_init(UART_INSTANCE_0, 115200, BUF_SIZE * 2, BUF_SIZE * 2, 50, &uart0_queue, ESP_INTR_FLAG_LEVEL1);
    uart_set_pin(UART_INSTANCE_0, 1, 3, 22, 19);

    xTaskCreate(uart_interrupt_task, "Tarea UART_0", BUF_SIZE * 4, NULL, 12, NULL);

    lcd_init();
}

void interpretar_trama_uart(const char* trama) {
    if (strstr(trama, "S") && strstr(trama, "E")) {
        uint8_t motor1, motor2, motor3;
        sscanf(trama, "S,%hhd,%hhd,%hhd,E", &motor1, &motor2, &motor3);

        uint8_t data[3] = {motor1, motor2, motor3};
        
        while(1){
 
            esp_err_t ret = i2c_master_write_to_device(MASTER_PORT, SLAVE_ADDR, data, (size_t)sizeof(data), pdMS_TO_TICKS(1000));

            if (ESP_OK == ret){
                printf("Datos enviados correctamente.\n");
                char lcd_data[30];
                sprintf(lcd_data,"M1:%d M2:%d M3:%d", motor1, motor2, motor3);
                lcd_clear(); 
                lcd_cursor(0, 1); 
                lcd_write_string(lcd_data);
                break;
            } 
            //else {
              //  printf("ERROR al enviar datos(se reintentara el envio): %s\n", esp_err_to_name(ret));
           // }

        }

        
    } else {
        printf("Trama invalida. Descartando.\n");
    }
}

static void uart_interrupt_task(void *params) {
    uart_event_t uart_event;
    char *uart_data_rec = (char *)malloc(BUF_SIZE);

    while (1) {
        if (xQueueReceive(uart0_queue, (void *)&uart_event, (TickType_t)portMAX_DELAY)) {
            bzero(uart_data_rec, BUF_SIZE);

            switch (uart_event.type) {
            case UART_DATA:
                uart_receive(UART_INSTANCE_0, (void *)uart_data_rec, (uint32_t)uart_event.size);
                interpretar_trama_uart(uart_data_rec);
                break;

            default:
                break;
            }
        }
    }

    free(uart_data_rec);
}


/*

// *************** Código para el SLAVE*********************************** //

#include <stdio.h>
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "driver/i2c.h"
#include "driver/gpio.h"
#include "driver/uart.h"
#include <stdlib.h>
#include <string.h>
#include "utilities1.h"




// Parámetros de configuración para la comunicación I2C
#define SLAVE_RX_BUF        1024
#define SLAVE_ADDR          0x32
#define SLAVE_SCL           22
#define SLAVE_SDA           21
#define BUF_SIZE            1024

#define LED_1 2
#define LED_2 4
#define LED_3 18


#define UART_INSTANCE_0 UART_NUM_0

static QueueHandle_t uart0_queue;



// Función de inicialización del controlador I2C para modo Slave
void i2c_slave_init() {

    i2c_config_t i2c_slave_config = {

    .mode = I2C_MODE_SLAVE,
    .sda_io_num = SLAVE_SDA,
    .sda_pullup_en = GPIO_PULLUP_ENABLE,
    .scl_io_num = SLAVE_SCL,
    .scl_pullup_en = GPIO_PULLUP_ENABLE,
    .slave.addr_10bit_en = 0,
    .slave.slave_addr = SLAVE_ADDR,
    };

    ESP_ERROR_CHECK(i2c_param_config(I2C_NUM_0, &i2c_slave_config));
    ESP_ERROR_CHECK(i2c_driver_install(I2C_NUM_0, i2c_slave_config.mode, SLAVE_RX_BUF*2, 0, 0));

    
}

void app_main() {
    
    i2c_slave_init();

    gpio_reset_pin(LED_1);
    gpio_reset_pin(LED_2);
    gpio_reset_pin(LED_3);
    gpio_set_direction(LED_1, GPIO_MODE_OUTPUT);
    gpio_set_direction(LED_2, GPIO_MODE_OUTPUT);
    gpio_set_direction(LED_3, GPIO_MODE_OUTPUT);

    uart_init(UART_INSTANCE_0, 115200, BUF_SIZE * 2, BUF_SIZE * 2, 50, &uart0_queue, ESP_INTR_FLAG_LEVEL1);
    uart_set_pin(UART_INSTANCE_0, 1, 3, 22, 19);

    

    size_t size = 3;
    uint8_t data[3];
    int len = 0;

    bzero(data, size);
    
    while(1) {
        
        // Se recibe eternamente información del Master
        len = i2c_slave_read_buffer(I2C_NUM_0, data, size, pdMS_TO_TICKS(50));
        if(len > 0) {
            printf("Received data: %d, %d, %d\n", data[0], data[1], data[2]);
            gpio_set_level(LED_1, data[0]);
            gpio_set_level(LED_2, data[1]);
            gpio_set_level(LED_3, data[2]);

            char uart_data[50];
            sprintf(uart_data, "Received data: %d, %d, %d\n", data[0], data[1], data[2]);
            uart_write_bytes(UART_INSTANCE_0, uart_data, strlen(uart_data));


        }
    }
}
*/