// Fill arrays with addresses
void mtsnArrayFilling() {
  for (uint8_t i = 0; i <= DATA_LENGTH - 2; i++) {
    mtsn_8_8p[i] = i + MTSN_8_8P_FIRST_BYTE;
    mtsn_xr[i] = i + MTSN_XR_FIRST_BYTE_1;
    mtsn_xr_2[i] = i + MTSN_XR_FIRST_BYTE_2;
    mtsn_x_xs_xsmax[i] = i + MTSN_X_XS_XSMAX_FIRST_BYTE_1;
    mtsn_x_xs_xsmax_2[i] = i + MTSN_X_XS_XSMAX_FIRST_BYTE_2;
    mtsn_x_xs_xsmax_3[i] = i + MTSN_X_XS_XSMAX_FIRST_BYTE_3;
  }
}

// Read data from the UART buffer
void readBuffer() {
  for (uint8_t i = 0; i <= DATA_LENGTH - 1; i++) {
    serial_input[i] = Serial.read();
  }
}

// Write a byte to EEPROM memory via the I2C interface
void writeByte(byte addr_eeprom, uint16_t addr, byte data) {
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.write(data);
  Wire.endTransmission();
}

// Write an array to EEPROM memory via the I2C interface
void writeArray(uint16_t mtsn[]) {
  for (uint8_t i = 0; i <= 43; i++) {
    writeByte(DEVICE_ADDRESS, mtsn[i], serial_input[i]);
    delay(5);
  }
}
