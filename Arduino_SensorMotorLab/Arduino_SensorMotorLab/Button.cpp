#include "Button.h"

void Button::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  
  button = pinIds[0];
  buttonState = LOW;
  lastButtonState = LOW;
  currentButtonState = LOW;
  
  
}

boolean Button::pressOccurred()
{
  currentButtonState = debounce(lastButtonState, button);
  if(currentButtonState == HIGH && lastButtonState == LOW){
      buttonState = HIGH;
      lastButtonState = currentButtonState;
    } 
    else{
       buttonState = LOW;
     }
  return buttonState;
 
}

boolean Button::debounce(boolean last, int button)
{
  boolean current = digitalRead(button);
  if (last != current)
  {
    delay(5);
    current = digitalRead(button);
  }
  return current;
}


