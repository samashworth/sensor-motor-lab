#ifndef ARDUINO_SENSORMOTORLAB_THERMISTOR_H
#define ARDUINO_SENSORMOTORLAB_THERMISTOR_H

#include "Sensor.h"

/*
Represents a thermistor.
*/
class Thermistor : public Sensor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual float getReading();

    virtual byte getRelativeReading();

    virtual SensorReadingInfo getSensorReadingInfo();

    virtual void doProcessing();
};

#endif /* ARDUINO_SENSORMOTORLAB_THERMISTOR_H */


