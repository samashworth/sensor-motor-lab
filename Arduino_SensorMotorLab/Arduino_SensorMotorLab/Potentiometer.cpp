#include "Potentiometer.h"
#include "Misc.h"

void Potentiometer::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  potPin = pinIds[0];
}

float Potentiometer::getReading()
{
  potReading = map(potVal, 0, 1023, 0, 270);
  return potReading;
}

byte Potentiometer::getRelativeReading()
{
  potRelative = map(potVal, 0, 1023, 0, 255);
  return potRelative;
}

SensorInfo Potentiometer::getSensorInfo() 
{
  // TODO @Sonali: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = CENTIMETER;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 270;
  
  return SensorInfo;
}

void Potentiometer::doProcessing()
{
  potVal = analogRead(potPin);
}

