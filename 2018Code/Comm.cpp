#include "Comm.h"

Comm::Comm(CommData* data, long baud_rate){
  _data_out = data;
  Serial.begin(baud_rate);
}

void Comm::update(){
  
}

