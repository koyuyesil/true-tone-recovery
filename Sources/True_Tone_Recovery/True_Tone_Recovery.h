#ifndef APPLE_TRUE_TONE_RECOVERY_H
#define APPLE_TRUE_TONE_RECOVERY_H

/**
 * Control Command Codes
 * 
 * Code - Symbol - Description
 * 65   - "A"    - For iPhone 8/8P
 * 66   - "B"    - For iPhone Xr
 * 67   - "C"    - For iPhone X/Xs/XsMax
**/
#define COMMAND_IP_8_8P 65
#define COMMAND_IP_XR 66
#define COMMAND_IP_X_XS_XSMAX 67

// Device address on the I2C bus
#define DEVICE_ADDRESS 0x51

// I2C bus data exchange speed
#define IIC_CLOCK 100000

// Serial communication baud rate
#define SERIAL_BAUDRATE 115200

// Length of received data packet (bytes)
#define DATA_LENGTH 45 //(44+1)

// Initial memory cell addresses (dec)
#define MTSN_8_8P_FIRST_BYTE 14903
#define MTSN_XR_FIRST_BYTE_1 15933
#define MTSN_XR_FIRST_BYTE_2 16128
#define MTSN_X_XS_XSMAX_FIRST_BYTE_1 4620
#define MTSN_X_XS_XSMAX_FIRST_BYTE_2 9068
#define MTSN_X_XS_XSMAX_FIRST_BYTE_3 15660

// Array for received bytes from UART
byte serial_input[DATA_LENGTH] = "";

// Arrays with memory cell addresses
uint16_t mtsn_8_8p[DATA_LENGTH - 1];
uint16_t mtsn_xr[DATA_LENGTH - 1];
uint16_t mtsn_xr_2[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax_2[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax_3[DATA_LENGTH - 1];

#endif
