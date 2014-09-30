#include "IRSensor.h"
#include "Misc.h"

void IRSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Roger: Implement this.
}

float IRSensor::getReading()
{
  // TODO @Roger: Implement this.
  return 0.0;
}

byte IRSensor::getRelativeReading()
{
  // TODO @Roger: Implement this.
  return 0;
}

SensorInfo IRSensor::getSensorInfo() 
{
  // TODO @Roger: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = METER;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void IRSensor::doProcessing()
{
  // TODO @Roger: Implement this.
}

