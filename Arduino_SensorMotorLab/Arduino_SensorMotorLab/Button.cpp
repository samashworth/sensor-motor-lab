#include "Button.h"

void Button::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  button = pinIds[0];
  buttonState = LOW;
  lastButtonState = LOW;
  currentButtonState = HIGH;
}

boolean Button::pressOccurred()
{
  currentButtonState = debounce(lastButtonState, button);
  if(currentButtonState == LOW && lastButtonState == HIGH){
      buttonState = HIGH;
      lastButtonState = currentButtonState;
    } 
    else{
       buttonState = LOW;
     }
  return buttonState;
}

boolean debounce(boolean last, int button)
{
  boolean current = digitalRead(button);
  if (last != current)
  {
    delay(5);
    current = digitalRead(button);
  }
  return current;
}


