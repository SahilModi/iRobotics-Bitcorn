#ifndef DOUBLE_PISTON_H
#define DOUBLE_PISTON_H

class DoublePiston{
public:
  DoublePiston(int address);
  DoublePiston(int address, int state);

  int setState(int new_state);
  int switchState();
  int getState();
private:
  int current_state;
  int pin_address;
};


#endif;
