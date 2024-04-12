#include "UART_LED_Control.h"
#include <string.h>

static QueueHandle_t uart_queue;

void ULC_init(UART_NUM uart_num, uint32_t baud_rate) {
    uart_init(uart_num, baud_rate, BUF_SIZE * 2, BUF_SIZE * 2, 50, &uart_queue, ESP_INTR_FLAG_LEVEL1);
    uart_set_pin(uart_num, 1, 3, 22, 19);
}

void ULC_task(void *params) {
    char *uart_recv_data = (char *)malloc(BUF_SIZE);
    while (1) {
        uart_event_t uart_event;
        if (xQueueReceive(uart_queue, (void *)&uart_event, (TickType_t)portMAX_DELAY)) {
            if (uart_event.type == UART_DATA) {
                uart_receive(UART_NUM_0, (void *)uart_recv_data, (uint32_t)uart_event.size);
                LEDState led_state;
                parse_led_command(uart_recv_data, &led_state);
                // Aquí deberías realizar la acción correspondiente con el estado de los LEDs
                // Por ejemplo, encender o apagar los LEDs según led_state
            }
        }
    }
    free(uart_recv_data);
}

void parse_led_command(const char *command, LEDState *led_state) {
    if (strlen(command) != LED_COMMAND_LENGTH ||
        command[0] != 'S' ||
        command[LED_COMMAND_LENGTH - 1] != 'E') {
        // Descartar trama inválida
        return;
    }

    int led_states[3];
    for (int i = 0; i < 3; i++) {
        led_states[i] = command[2 + i*2] - '0';
        if (led_states[i] != 0 && led_states[i] != 1) {
            // Descartar trama inválida
            return;
        }
    }

    led_state->led1_on_off = (bool)led_states[0];
    led_state->led2_on_off = (bool)led_states[1];
    led_state->led3_on_off = (bool)led_states[2];
}
