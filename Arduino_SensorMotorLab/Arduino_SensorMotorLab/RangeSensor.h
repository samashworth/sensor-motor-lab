#ifndef ARDUINO_SENSORMOTORLAB_RANGESENSOR_H
#define ARDUINO_SENSORMOTORLAB_RANGESENSOR_H

#include "Sensor.h"

/*
Represents a range sensor.
*/
class RangeSensor : public Sensor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual float getReading();

    virtual byte getRelativeReading();

    virtual SensorReadingInfo getSensorReadingInfo();

    virtual void doProcessing();
};

#endif /* ARDUINO_SENSORMOTORLAB_RANGESENSOR_H */


