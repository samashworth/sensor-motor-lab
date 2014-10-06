#ifndef ARDUINO_SENSORMOTORLAB_BUTTON_H
#define ARDUINO_SENSORMOTORLAB_BUTTON_H

#include <Arduino.h>

class Button {
  public:
    /*
    Initializes the sensor. 
    Parameters:
		numPins:
			The number of pins allocated to this sensor.
		pinIds:
			The ids of the pins allocated to this sensor. The sensor can use these pins as
		it wishes.
		numInterrupts:
			The number of interrupts allocated to this sensor.
		interruptIds:
			The interrupt ids allocated to the sensor.
    */
    void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
    
    /*
    Returns true if a button press occurred between the last invocation of this function and the present invocation.
    This function will be called on every iteration of the main loop.
    */
    boolean pressOccurred();
    
    boolean debounce(boolean last, int button);

    private:
    int button;
    boolean buttonState;
    boolean lastButtonState;
    boolean currentButtonState;   
};



#endif /* ARDUINO_SENSORMOTORLAB_BUTTON_H */
