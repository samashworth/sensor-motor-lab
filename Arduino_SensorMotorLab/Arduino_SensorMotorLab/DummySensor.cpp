#include "DummySensor.h"
#include "Misc.h"
#include "Messenger.h"

int reading = 0;

void DummySensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  Messenger::reportError("This is a test error");
}

float DummySensor::getReading()
{
	return reading++ % 3;
}

byte DummySensor::getRelativeReading()
{
	return reading++ % 3;
}

SensorInfo DummySensor::getSensorInfo() 
{
  SensorInfo SensorInfo;
  SensorInfo.units = CELSIUS;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void DummySensor::doProcessing()
{
}

