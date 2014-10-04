#include "Messenger.h"

void Messenger::initialize() {
  Serial.begin(9600);
}

void Messenger::send(Message message) {
  Serial.write(message.messageType);
  Serial.write(message.peripheralType);
  byte* b = (byte*) &message.payload;
  Serial.write(b, 4);
}

void Messenger::reportError(String message) {
  Serial.println(message);
}