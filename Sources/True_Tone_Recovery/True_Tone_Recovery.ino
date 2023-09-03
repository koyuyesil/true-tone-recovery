#include <Wire.h>
#include "True_Tone_Recovery.h"

/**
 * Apple True Tone Recovery
 * 
 * Allows you to restore the True Tone function
 * by rewriting the serial number mtSN (Cover Board Number)
 * Supported iPhone models: 8/8P/X/Xr/Xs/XsMax
 * 
 * Copyright (C) 2020. v1.0 / Roman Sklyar S-LAB
 * COMPILED IN ARDUINO V1.8.12
 * 
 */

void setup() {
  mtsnArrayFilling();
  Serial.begin(SERIAL_BAUDRATE);
  Wire.begin();
  Wire.setClock(IIC_CLOCK);
}

void loop() {
  // 44 bayt seri port data varmı bak varsa readbuffer
  if(Serial.available() == DATA_LENGTH){
    readBuffer();
    // serial gelen data son harfine baklılır case secilir
    switch(serial_input[DATA_LENGTH - 1]){
      case COMMAND_IP_8_8P:
      //oluşturulan arraylar yazılır. seriporttan gelen değil
      writeArray(mtsn_8_8p);
      break;
      case COMMAND_IP_XR:
      writeArray(mtsn_xr);
      writeArray(mtsn_xr_2);
      break;
      case COMMAND_IP_X_XS_XSMAX:
      writeArray(mtsn_x_xs_xsmax);
      writeArray(mtsn_x_xs_xsmax_2);
      writeArray(mtsn_x_xs_xsmax_3);
      break;
    }
  }
}
