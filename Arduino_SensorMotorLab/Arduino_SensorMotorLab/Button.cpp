#include "Button.h"
#include "Messenger.h"


void Button::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  
  button = pinIds[0];
  pinMode(button,INPUT);
  buttonState = LOW;
  lastButtonState = LOW;
  currentButtonState = HIGH;
  
  
}

boolean Button::pressOccurred()
{
  currentButtonState = debounce(lastButtonState, button);
  if(currentButtonState == LOW && lastButtonState == HIGH){
      Messenger::printMessage("Button Pressed", false);
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


