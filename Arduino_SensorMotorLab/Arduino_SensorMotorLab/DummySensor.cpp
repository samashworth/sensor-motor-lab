#include "DummySensor.h"
#include "Misc.h"
#include "Messenger.h"

DummySensor::DummySensor() {
  reading = -5.0;
}

void DummySensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  Messenger::printMessage("DummySensor initialize", true);
}

float DummySensor::getReading()
{
  Messenger::printMessage("DummySensor getReading", true);
	float r = reading;
  float d = reading - 5;
  if (d > -0.01 && d < 0.01)
    reading = -5.0;
  else
    reading += 0.5;
  return r;
}

byte DummySensor::getRelativeReading()
{
	byte result = (byte)((reading + 5.0) / 10.0 * 255.0);
	Messenger::printMessage("DummySensor getRelativeReading: " + result, true);
  return result;
}

SensorInfo DummySensor::getSensorInfo() 
{
  Messenger::printMessage("DummySensor getSensorInfo", true);
  SensorInfo SensorInfo;
  SensorInfo.units = CELSIUS;
  SensorInfo.minReading = -5;
  SensorInfo.maxReading = 5;
  
  return SensorInfo;
}

void DummySensor::doProcessing()
{
}

