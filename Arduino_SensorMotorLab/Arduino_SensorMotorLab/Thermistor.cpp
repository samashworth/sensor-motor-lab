#include "Thermistor.h"
#include "Misc.h"


void Thermistor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // Nothing to do
}

float Thermistor::getReading()
{
  int units = analogRead(temperaturePin);
  float temperature = units/2;
  if (temperature > 30) {                        // check if the temperature reading is outside of your specified limits
    temperature = 30;
  }
  if (temperature < 25) {
    units = 25;
  }
  return temperature;
}

byte Thermistor::getRelativeReading()
{
  int units = analogRead(temperaturePin);
  if (units > 61) {                        // check if the temperature reading is outside of your specified limits
    units = 61;
  }
  if (units < 51) {
    units = 51;
  }
  int relativeReading = 51*((units/2)-25);
  return relativeReading;
}

SensorInfo Thermistor::getSensorInfo() 
{
  // TODO @Erin: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = CELSIUS;
  SensorInfo.minReading = 10;
  SensorInfo.maxReading = 40;
  
  return SensorInfo;
}

void Thermistor::doProcessing()
{
  // Nothing to do
}

