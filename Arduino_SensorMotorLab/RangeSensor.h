#ifndef ARDUINO_SENSORMOTORLAB_RANGESENSOR_H
#define ARDUINO_SENSORMOTORLAB_RANGESENSOR_H

#include "Sensor.h"

/*
Represents a range sensor.
*/
class RangeSensor : public Sensor {
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
      errorMessage:
          If initialization is unsuccessful, errorMessage should be set to an explanatory
          message that will be displayed to the user.
    Return Value: True if initialization is successful and False otherwise.
    */
    virtual boolean initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[], String* errorMessage);
    
    /*
    Returns the current reading from the sensor.
    */
    virtual int getReading();
    
    /*
    Returns info about the readings produced by this sensor. This includes the units of the readings,
    the minimum and maximum possible readings, and the scale factor that a consumer of the readings should apply
    to the readings.
    */
    virtual SensorReadingInfo getSensorReadingInfo();
    
    
    /*
    Allows the sensor code to do any processing it needs to do, such as reading pins and updating internal
    variables. This method will be called once on every iteration of the main Arduino loop.
    Return Value: True if processing was successful and False otherwise.
    Parameters:
      errorMessage:
          If an error occurs, errorMessage should be set to an explanatory message that will be displayed to the user.
    */
    virtual boolean doProcessing(String* errorMessage);
};

#endif /* ARDUINO_SENSORMOTORLAB_RANGESENSOR_H */


