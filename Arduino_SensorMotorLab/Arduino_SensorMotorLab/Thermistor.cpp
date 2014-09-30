#include "Thermistor.h"
#include "Misc.h"


void Thermistor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Erin: Implement this.
}

float Thermistor::getReading()
{
  // TODO @Erin: Implement this.
  return 0.0;
}

byte Thermistor::getRelativeReading()
{
  // TODO @Erin: Implement this.
  return 0;
}

SensorInfo Thermistor::getSensorInfo() 
{
  // TODO @Erin: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = CELSIUS;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void Thermistor::doProcessing()
{
  // TODO @Erin: Implement this.
}

