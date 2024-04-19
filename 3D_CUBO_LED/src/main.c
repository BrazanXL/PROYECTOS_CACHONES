#include <stdio.h>
#include <string.h>
#include "driver/gpio.h"
#include "driver/uart.h"
#include "driver/i2c.h"
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "freertos/queue.h"
#include "esp_intr_alloc.h"
#include "esp_log.h"
#include "lcd_i2c.h"
#include "utilities1.h"


#define BUF_SIZE 1024
#define SLAVE_ADDR 0x32
#define MASTER_PORT I2C_NUM_0
#define MASTER_SDA 21
#define MASTER_SCL 22
#define MASTER_FREQ_HZ 100000
#define UART_INSTANCE_0 UART_NUM_0



void app_main() {}

