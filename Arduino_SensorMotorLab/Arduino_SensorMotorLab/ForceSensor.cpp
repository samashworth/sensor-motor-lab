#include "ForceSensor.h"
#include "Misc.h"

void ForceSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Sowmya: Implement this.
}

float ForceSensor::getReading()
{
  // TODO @Sowmya: Implement this.
  return 0.0;
}

byte ForceSensor::getRelativeReading()
{
  // TODO @Sowmya: Implement this.
  return 0;
}

SensorReadingInfo ForceSensor::getSensorReadingInfo() 
{
  // TODO @Sowmya: Implement this.
  SensorReadingInfo sensorReadingInfo;
  sensorReadingInfo.units = NEWTON;
  sensorReadingInfo.minReading = 0;
  sensorReadingInfo.maxReading = 0;
  
  return sensorReadingInfo;
}

void ForceSensor::doProcessing()
{
  // TODO @Sowmya: Implement this.
}

