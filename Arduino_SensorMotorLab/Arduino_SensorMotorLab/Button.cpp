#include "Button.h"
#include "Messenger.h"


void Button::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  
  button = pinIds[0];
  buttonState = LOW;
  lastButtonState = LOW;
  currentButtonState = LOW;
}

boolean Button::pressOccurred()
{
  boolean currentButtonState = digitalRead(button);
  if(currentButtonState == HIGH && lastButtonState == LOW){
      delay(100);
      buttonState = HIGH;
      lastButtonState = currentButtonState;
      Messenger::printMessage("Button Pressed!", false);

    } 
    else{
       buttonState = LOW;
       lastButtonState = LOW;
     }
  return buttonState;
 
}




