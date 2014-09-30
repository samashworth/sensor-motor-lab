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

SensorReadingInfo Thermistor::getSensorReadingInfo() 
{
  // TODO @Erin: Implement this.
  SensorReadingInfo sensorReadingInfo;
  sensorReadingInfo.units = CELSIUS;
  sensorReadingInfo.minReading = 0;
  sensorReadingInfo.maxReading = 0;
  
  return sensorReadingInfo;
}

void Thermistor::doProcessing()
{
  // TODO @Erin: Implement this.
}

