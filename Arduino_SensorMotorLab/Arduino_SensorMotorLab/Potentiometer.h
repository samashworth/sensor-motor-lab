#ifndef ARDUINO_SENSORMOTORLAB_Potentiometer_H
#define ARDUINO_SENSORMOTORLAB_Potentiometer_H

#include "Sensor.h"

/*
Represents a range sensor.
*/
class Potentiometer : public Sensor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual float getReading();

    virtual byte getRelativeReading();

    virtual SensorInfo getSensorInfo();

    virtual void doProcessing();
    
    virtual SensorType getSensorType() { return POTENTIOMETER; }
    
  private:
    // If you want, you can put variables here so that you can remember data from one call to the next.
    int potVal;
    int potReading;
    int potRelative;
    int potPin;
};

#endif /* ARDUINO_SENSORMOTORLAB_Potentiometer_H */


