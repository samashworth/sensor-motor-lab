#include "Messenger.h"

char Messenger::buffer[BUFFER_SIZE];
int Messenger::bufferPos = 0;
boolean Messenger::debugMode = false;

void Messenger::initialize() {
  Serial.begin(115200);
}

void Messenger::send(Message message) {
  Messenger::printMessage("Send message", true);
  Serial.write(START_CODE);
  Serial.write(message.messageType);
  Serial.write(message.motorType);
  Serial.write(message.sensorType);
  Serial.write(message.messagePayload.payloadByte, 4);
  Serial.write(STOP_CODE);
}

boolean Messenger::recieve(Message* message) {
  byte b;
  boolean messageReceived = false;
  while (Serial.available()) {
    if (Messenger::bufferPos + 1 == BUFFER_SIZE) {
      Messenger::bufferPos = 0;
    }
    b = Serial.read();
    if (Messenger::bufferPos == 0 && b != START_CODE)
      continue;
    Messenger::buffer[Messenger::bufferPos++] = b;
    if (b == STOP_CODE)      
      if (Messenger::buffer[0] != START_CODE)
      {
        Messenger::bufferPos = 0;
        continue;
      }
      message->messageType = (MessageType)Messenger::buffer[1];
      message->motorType = (MotorType)Messenger::buffer[2];
      message->sensorType = (SensorType)Messenger::buffer[3];
      for (int i = 0; i < PAYLOAD_LENGTH; i++) {
        message->messagePayload.payloadByte[i] = Messenger::buffer[i + 4];
      }
      messageReceived = true;
      Messenger::printMessage("Message received", true);
  }
  return messageReceived;
}

void Messenger::reportError(String message) {
  Serial.write(START_CODE);
  Serial.write(ERROR_GET);
  Serial.write(message.length());
  Serial.println(message);
  Serial.write(STOP_CODE);
}

void Messenger::printMessage(String message, boolean onlyInDebug) {
  if (Messenger::debugMode || !onlyInDebug) {
    Serial.write(START_CODE);
    Serial.write(STRING_GET);
    Serial.write(message.length());
    Serial.println(message);
    Serial.write(STOP_CODE);
  }  
}