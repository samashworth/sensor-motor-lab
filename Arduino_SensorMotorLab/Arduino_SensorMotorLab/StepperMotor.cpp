#include "StepperMotor.h"
#include "Misc.h"


void StepperMotor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
    stepperPin = pinIds[0];
    directionPin = pinIds[1];
    pinMode(stepperPin,OUTPUT);
    pinMode(directionPin,OUTPUT);
    currentSpeed = 0;
    currentDelay = 0;
}

int StepperMotor::getMaxSpeed()
{
  return 75;
}

int StepperMotor::getSpeed()
{
  return currentSpeed;
  return 0;
}

void StepperMotor::setSpeed(int rpm)
{
  if (rpm < 0) {
    digitalWrite(directionPin,HIGH);
    rpm = abs(rpm);
    currentSpeed = rpm;
    currentDelay = 150/rpm;// delay time in ms
  }
  else {
    digitalWrite(directionPin,LOW);
    currentSpeed = rpm;
    currentDelay = 150/rpm; // delay time in ms
  }
}

void StepperMotor::setAngle(int deg)
{
  if (deg < 0) {
    digitalWrite(directionPin,HIGH);
    int steps = abs(deg)*10/18;      // calculate the number of steps to rotate
  }
  else {
    digitalWrite(directionPin,LOW);
    int steps = deg*10/18;      // calculate the number of steps to rotate
  }
  setSpeed(6);                // always do the angle rotation at the slowest speed (6rpm = .1 rot/s)
  for(int i=0;i<steps;i++) {  // rotate the appropriate number of steps
    doProcessing();
  }
  setSpeed(0);
}

void StepperMotor::doProcessing()
{
  if (currentSpeed == 0) {
    // do nothing
  }
  else {
      unsigned long startTime;
      digitalWrite(stepperPin,HIGH);
      // delay(currentDelay);
      
      startTime = millis();
      while ( (millis() - startTime)  < currentDelay) {
        // wait
      }
      
      digitalWrite(stepperPin,LOW);
      // delay(currentDelay);
      
      startTime = millis();
      while ( (millis() - startTime)  < currentDelay) {
        // wait
      }  
   }
  
}


