#ifndef COMM_H_
#define COMM_H_

#include <Arduino.h>
#include "CommData.h"
#include<SoftwareSerial.h>

/**
 * This code is for one controller
 * refer to Packet Structure.pdf
 */

#define time_out 500

class Comm{
public:
  Comm(CommData* data, long baud_rate, SoftwareSerial*);
  /**
   * Basically, write out to PC through serial,
   * and read from serial, update the internal servo values.
   */
//  void write();
  void update();
  void failsafe();

  int getFailures(); 
  
  
private:
  SoftwareSerial *XBee;
  boolean connection;
  byte x;
  byte packet_index;
  byte i;
  byte size;
  byte checkSumTX;    // check sum for transmitting data
  byte checkSumRX;    // check sum for recieving data 
  unsigned long read_time;
  
  byte _data[8];
  byte _controller[8];
  byte _feedback[10];
  CommData *_data_out;

  int _count_fail;
};

#endif
