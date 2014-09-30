#include "RangeSensor.h"
#include "Misc.h"

void RangeSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Roger: Implement this.
}

float RangeSensor::getReading()
{
  // TODO @Roger: Implement this.
  return 0.0;
}

byte RangeSensor::getRelativeReading()
{
  // TODO @Roger: Implement this.
  return 0;
}

SensorReadingInfo RangeSensor::getSensorReadingInfo() 
{
  // TODO @Roger: Implement this.
  SensorReadingInfo sensorReadingInfo;
  sensorReadingInfo.units = METER;
  sensorReadingInfo.minReading = 0;
  sensorReadingInfo.maxReading = 0;
  
  return sensorReadingInfo;
}

void RangeSensor::doProcessing()
{
  // TODO @Roger: Implement this.
}

