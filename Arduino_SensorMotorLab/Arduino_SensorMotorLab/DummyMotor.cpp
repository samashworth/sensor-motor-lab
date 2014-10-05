#include "DummyMotor.h"
#include "Misc.h"
#include "Messenger.h"

DummyMotor::DummyMotor() {
  speed = 0;
  angle = 0;
}

void DummyMotor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  Messenger::printMessage("DummyMotor initialize", true);
}

int DummyMotor::getMaxSpeed()
{
  //Messenger::printMessage("DummyMotor getMaxSpeed", true);
  return 10;
}

int DummyMotor::getSpeed()
{
  Messenger::printMessage("DummyMotor getSpeed", true);
  return speed;
}

void DummyMotor::setSpeed(int rpm)
{
  //Messenger::printMessage("DummyMotor setSpeed: " + String(rpm), true);
  speed = rpm;
  angle = 0;
}

void DummyMotor::setAngle(int deg)
{
  Messenger::printMessage("DummyMotor setAngle: " + String(deg), true);
  angle = deg;
  speed = 0;
}

void DummyMotor::doProcessing()
{
}


