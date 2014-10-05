#ifndef ARDUINO_SENSORMOTORLAB_RCSERVOMOTOR_H
#define ARDUINO_SENSORMOTORLAB_RCSERVOMOTOR_H

#include <Arduino.h>
// Unfortunately, we can't include other Arduino libraries in a custom class file.
#include <Servo.h>
#include "RCServoMotor.h"
#include "Misc.h"
#include "Messenger.h"
#include "Motor.h"

/*
Represents an RC servo motor.
*/
class RCServoMotor : public Motor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual int getMaxSpeed();

    virtual int getSpeed();

    virtual void setSpeed(int rpm);

    virtual void setAngle(int deg);

    virtual void doProcessing();
    
    virtual MotorType getMotorType() { return RC_SERVO_MOTOR; }
    
  private:
    // If you want, you can put variables here so that you can remember data from one call to the next.
    Servo servoMotor; //stores servo object
    int servoControlPin; // Stores the pin number for servo contol. required to be analogue write
};

void RCServoMotor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  Servo servoMotor; //create servo object
  if (numPins != 1){
    Messenger::reportError("ERROR in Servo Motor Control: Number of pins recieved is different than expected");
  }
  servoControlPin = pinIds[0];
  servoMotor.attach(servoControlPin);
}

int RCServoMotor::getMaxSpeed()
{
  // returns null- no speed settings for this device
  return 0;
}

int RCServoMotor::getSpeed()
{
  // returns angle- no speed settings enabeled for this device
  return servoMotor.read();
}

void RCServoMotor::setSpeed(int rpm)
{
  // sets nothing, no speed control on servo implemented at this time
}

void RCServoMotor::setAngle(int deg)
{
  // input is angle from 0 to 180, 90 is center position
  servoMotor.write(deg);
}

void RCServoMotor::doProcessing()
{
  // do nothing
}


#endif /* ARDUINO_SENSORMOTORLAB_RCSERVOMOTOR_H */



