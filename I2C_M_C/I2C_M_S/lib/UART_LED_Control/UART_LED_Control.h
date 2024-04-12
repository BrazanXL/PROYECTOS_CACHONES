#include "utilities.h"
#include <stdbool.h>

#define LED_COMMAND_LENGTH 11 // Longitud de la trama esperada: S,1,1,1,E

typedef struct {
    bool led1_on_off;
    bool led2_on_off;
    bool led3_on_off;
} LEDState;

void uart_led_control_init(UART_NUM uart_num, uint32_t baud_rate);
void uart_led_control_task(void *params);
void parse_led_command(const char *command, LEDState *led_state);
