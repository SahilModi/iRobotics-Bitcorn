#ifndef COMM_H_
#define COMM_H_

#include <Arduino.h>
#include "CommData.h"

//for one joystick
#define PACKET_SIZE = 8;

/**
 * refer to Packet Structure.pdf
 */

class Comm{
public:
  Comm(CommData* data, long baud_rate);
  /**
   * Basically, write out to PC through serial,
   * and read from serial, update the internal servo values.
   */
//  void write();
  void update();
  
  
private:
  byte _data[8];
  CommData *_data_out;
};

#endif
