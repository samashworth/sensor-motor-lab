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

SensorInfo ForceSensor::getSensorInfo() 
{
  // TODO @Sowmya: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = NEWTON;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void ForceSensor::doProcessing()
{
  // TODO @Sowmya: Implement this.
}

