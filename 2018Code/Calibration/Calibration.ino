#include <Servo.h>

int pos = 0;

Servo serv;
void setup() {
  // put your setup code here, to run once:
  serv.attach(8);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    serv.write(pos);              // tell servo to go to position in variable 'pos'
    delay(50);                       // waits 15ms for the servo to reach the position
  }
  for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
    serv.write(pos);              // tell servo to go to position in variable 'pos'
    delay(50);                       // waits 15ms for the servo to reach the position
    if(pos == 90){
      Serial.println("Neutral");
      delay(3000);
    }
  }
}
