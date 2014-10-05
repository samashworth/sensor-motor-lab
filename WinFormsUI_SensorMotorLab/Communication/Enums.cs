using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public enum Units { NEWTON, CENTIMETER, CELSIUS };

    public enum MotorType { DC_MOTOR, RC_SERVO_MOTOR, STEPPER_MOTOR, DUMMY_MOTOR };

    public enum SensorType { FORCE_SENSOR, POTENTIOMETER, SONAR_SENSOR, THERMISTOR, DUMMY_SENSOR };

    public enum MessageType { READING_GET, ANGLE_GET, ANGLE_SET, SPEED_GET, SPEED_SET, ERROR_GET, STRING_GET, SENSOR_MOTOR_BINDING_SET };

    public enum MotorFunction { POSITION, SPEED };

    public enum Direction { CCW, CW }; 
}
