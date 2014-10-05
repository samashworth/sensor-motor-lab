#include "Potentiometer.h"
#include "Misc.h"

void Potentiometer::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Sonali: Implement this.
}

float Potentiometer::getReading()
{
  // TODO @Sonali: Implement this.
  return 0.0;
}

byte Potentiometer::getRelativeReading()
{
  // TODO @Sonali: Implement this.
  return 0;
}

SensorInfo Potentiometer::getSensorInfo() 
{
  // TODO @Sonali: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = CENTIMETER;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void Potentiometer::doProcessing()
{
  // TODO @Sonali: Implement this.
}

