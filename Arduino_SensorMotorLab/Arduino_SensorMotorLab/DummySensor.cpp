#include "DummySensor.h"
#include "Misc.h"

int reading = 0;

void DummySensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
}

float DummySensor::getReading()
{
	return reading++ % 3;
}

byte DummySensor::getRelativeReading()
{
	return reading++ % 3;
}

SensorReadingInfo DummySensor::getSensorReadingInfo() 
{
  SensorReadingInfo sensorReadingInfo;
  sensorReadingInfo.units = CELSIUS;
  sensorReadingInfo.minReading = 0;
  sensorReadingInfo.maxReading = 0;
  
  return sensorReadingInfo;
}

void DummySensor::doProcessing()
{
}

