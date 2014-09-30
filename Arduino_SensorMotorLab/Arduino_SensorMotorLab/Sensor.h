#ifndef ARDUINO_SENSORMOTORLAB_SENSOR_H
#define ARDUINO_SENSORMOTORLAB_SENSOR_H

#include <Arduino.h>
#include "SensorReadingInfo.h"

/*
Represents a sensor. Facilitates reading the sensor.
*/
class Sensor {
  public:
    /*
    Initializes the sensor. 
    Parameters:
      pinIds: 
          The ids of the pins allocated to this sensor. The sensor can use these pins as
          it wishes. This method will return false if too few or too many pins are allocated
          to the sensor.
      interruptIds: 
          The interrupt ids allocated to the sensor. Can be null. This method will return 
          false if too few or too many interrupts are allocated to the sensor.
    */
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
    
    /*
    Returns the current reading from the sensor, in the units measured by the sensor. For example, on a force sensor,
    this function will return a value in newtons.
    */
    virtual float getReading();
    
    /*
    Returns the current reading from the sensor, relative to the sensor's complete range. For example, if the sensor is
    a force sensor and the range of values is expected to be between 0 newtons and 700 newtons and the current reading
    of the sensor is 400 newtons, then this function will return 400 * 255 / 700 = 145.
    */
    virtual byte getRelativeReading();
    
    /*
    Returns info about the readings produced by this sensor. This includes the units of the readings and the minimum
	and maximum possible readings.
    */
    virtual SensorReadingInfo getSensorReadingInfo();
    
    
    /*
    Allows the senso code to do any processing it needs to do, such as reading pins and updating internal
    variables. This method will be called once on every iteration of the main Arduino loop.
    */
    virtual void doProcessing();
};

#endif /* ARDUINO_SENSORMOTORLAB_SENSOR_H */


