#include "ForceSensor.h"
#include "Misc.h"

void ForceSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  fsrPin = pinIds[0];
}

float ForceSensor::getReading()
{
  fsrVoltage = map(fsrRead, 0, 1023, 0, 5000);
  if (fsrVoltage == 0) {
      fsrForce = 0;  
    } else {
              
      fsrResistance = 5000 - fsrVoltage;     // 5V = 5000mV
      fsrResistance *= 10000;                // 10K ohm resistor
      fsrResistance /= fsrVoltage;
      
   
      fsrConductance = 1000000;           // micromhos 
      fsrConductance /= fsrResistance;
       
        if (fsrConductance <= 1000) {
        fsrForce = fsrConductance / 80;            
      } else {
        fsrForce = fsrConductance - 1000;
        fsrForce /= 30;              
      }
    }
  return fsrForce;
}

byte ForceSensor::getRelativeReading()
{
  fsrForceRead = ForceSensor::getReading();
  fsrRelative = map(fsrForceRead, 0, 7, 0, 255);
  
  return fsrRelative;
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
  fsrRead = analogRead(fsrPin); 
  
}

