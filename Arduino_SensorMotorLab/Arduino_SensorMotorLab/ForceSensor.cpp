#include "ForceSensor.h"
#include "Misc.h"

void ForceSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  fsPin = pinIds[0];
}

float ForceSensor::getReading()
{
  fsVoltage = map(fsRead, 0, 1023, 0, 5000);
  if (fsVoltage == 0) {
      fsForce = 0;  
    } else {
              
      fsResistance = 5000 - fsVoltage;     // 5V = 5000mV
      fsResistance *= 10000;                // 10K ohm resistor
      fsResistance /= fsVoltage;
      
   
      fsConductance = 1000000;           // micromhos 
      fsConductance /= fsResistance;
       
        if (fsConductance <= 1000) {
        fsForce = fsConductance / 80;            
      } else {
        fsForce = fsConductance - 1000;
        fsForce /= 30;              
      }
    }
  return fsForce;
}

byte ForceSensor::getRelativeReading()
{
  fsForceRead = ForceSensor::getReading();
  fsRelative = map(fsForceRead, 0, 7, 0, 255);
  
  return fsRelative;
}

SensorInfo ForceSensor::getSensorInfo() 
{
  
  SensorInfo SensorInfo;
  SensorInfo.units = NEWTON;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 8;
  
  return SensorInfo;
}

void ForceSensor::doProcessing()
{
  fsRead = analogRead(fsPin); 
  
}

