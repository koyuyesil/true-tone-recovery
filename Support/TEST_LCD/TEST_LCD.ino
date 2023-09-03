/**
 * mode: 1 - Scan 2 - Read 3 - Write
 */

#include <Wire.h>
#define DEV_ADDR 0x51 // Device address on the I2C bus
#define EMPTY_BYTE 0xFF // Empty byte (can be any value)
#define START_BYTE 4620 // Start address of memory 8/8p-14903 xr-15933:16128 x/xs/xsmax-4620:9068:15660
#define END_BYTE 4663 // End address of memory 8/8p-14946 xr-15976:16171 x/xs/xsmax-4663:9111:15703
#define IIC_CLOCK 100000 // I2C bus frequency
#define SERIAL_BAUDRATE 115200 // Serial communication baud rate

void Scanner() {
  Serial.println("scanning address");
  byte err, addr;
  for (addr = 8; addr < 127; addr++ ) {
    Wire.beginTransmission(addr);
    //Serial.println(addr);
    err = Wire.endTransmission();
    if (err == 0) {
      Serial.print("found address 0x");
      if (addr < 16)
        Serial.print("0");
        Serial.print(addr, HEX);
        Serial.print("\n");
      }
    }
  Serial.println("scanning end");
}

void Read_byte(uint8_t addr_eeprom, uint16_t addr) {
  char result;
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.endTransmission();
  Wire.requestFrom((int)(addr_eeprom), (int)(1));
  delay(5);
  if(Wire.available()){
    result = Wire.read();
    Serial.print(result);
  }
}

void Write_byte(uint8_t addr_eeprom, uint16_t addr, uint8_t data) {
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.write(data);
  Wire.endTransmission();
}

void Read(uint16_t start_b, uint16_t end_b) {
  for(uint16_t i = start_b ; i <= end_b; i++){
    Read_byte(DEV_ADDR, i);
  }
  Serial.print("\n");
}

void Write(uint16_t start_b, uint16_t end_b) {
  for(uint16_t i = start_b ; i <= end_b; i++){
    Write_byte(DEV_ADDR, i, EMPTY_BYTE);
    delay(5);
  }
  Serial.println("cleaning finished");
}

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  Wire.begin();
  Wire.setClock(IIC_CLOCK);
}

void loop() {
  if(Serial.available() > 0) {
    uint8_t mode = Serial.read() - '0';
    switch(mode) {
    case 1:
      Scanner();
      break;
    case 2:
      Read(START_BYTE, END_BYTE);
      break;
    case 3:
      Write(START_BYTE, END_BYTE);
      break;
    default:
      Serial.println("error command");
      Serial.println("1-scan 2-read 3-write");
    }
  }
}
