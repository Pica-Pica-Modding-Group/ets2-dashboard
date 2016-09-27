using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_dashboard_lib
{
    public class ETS2_Data
    {
        public static ETS2_Data Generate(string json)
        {
            return (ETS2_Data) Newtonsoft.Json.JsonConvert.DeserializeObject<ETS2_Data>(json);
        }

        public class Game
        {
            public bool connected { get; set; }
            public string gameName { get; set; }
            public bool paused { get; set; }
            public DateTime time { get; set; }
            public float timeScale { get; set; }
            public DateTime nextRestStopTime { get; set; }
            public string version { get; set; }
            public string telemetryPluginVersion { get; set; }
        }

        public class Placement
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
            public float heading { get; set; }
            public float pitch { get; set; }
            public float roll { get; set; }
        }

        public class Acceleration
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Head
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Cabin
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Hook
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Truck
        {
            public string id { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public float speed { get; set; }
            public float cruiseControlSpeed { get; set; }
            public bool cruiseControlOn { get; set; }
            public float odometer { get; set; }
            public int gear { get; set; }
            public int displayedGear { get; set; }
            public int forwardGears { get; set; }
            public int reverseGears { get; set; }
            public string shifterType { get; set; }
            public float engineRpm { get; set; }
            public float engineRpmMax { get; set; }
            public float fuel { get; set; }
            public float fuelCapacity { get; set; }
            public float fuelAverageConsumption { get; set; }
            public float fuelWarningFactor { get; set; }
            public bool fuelWarningOn { get; set; }
            public float wearEngine { get; set; }
            public float wearTransmission { get; set; }
            public float wearCabin { get; set; }
            public float wearChassis { get; set; }
            public float wearWheels { get; set; }
            public float userSteer { get; set; }
            public float userThrottle { get; set; }
            public float userBrake { get; set; }
            public float userClutch { get; set; }
            public float gameSteer { get; set; }
            public float gameThrottle { get; set; }
            public float gameBrake { get; set; }
            public float gameClutch { get; set; }
            public int shifterSlot { get; set; }
            public bool engineOn { get; set; }
            public bool electricOn { get; set; }
            public bool wipersOn { get; set; }
            public int retarderBrake { get; set; }
            public int retarderStepCount { get; set; }
            public bool parkBrakeOn { get; set; }
            public bool motorBrakeOn { get; set; }
            public float brakeTemperature { get; set; }
            public float adblue { get; set; }
            public float adblueCapacity { get; set; }
            public float adblueAverageConsumption { get; set; }
            public bool adblueWarningOn { get; set; }
            public float airPressure { get; set; }
            public bool airPressureWarningOn { get; set; }
            public float airPressureWarningValue { get; set; }
            public bool airPressureEmergencyOn { get; set; }
            public float airPressureEmergencyValue { get; set; }
            public float oilTemperature { get; set; }
            public float oilPressure { get; set; }
            public bool oilPressureWarningOn { get; set; }
            public float oilPressureWarningValue { get; set; }
            public float waterTemperature { get; set; }
            public bool waterTemperatureWarningOn { get; set; }
            public float waterTemperatureWarningValue { get; set; }
            public float batteryVoltage { get; set; }
            public bool batteryVoltageWarningOn { get; set; }
            public float batteryVoltageWarningValue { get; set; }
            public float lightsDashboardValue { get; set; }
            public bool lightsDashboardOn { get; set; }
            public bool blinkerLeftActive { get; set; }
            public bool blinkerRightActive { get; set; }
            public bool blinkerLeftOn { get; set; }
            public bool blinkerRightOn { get; set; }
            public bool lightsParkingOn { get; set; }
            public bool lightsBeamLowOn { get; set; }
            public bool lightsBeamHighOn { get; set; }
            public bool lightsAuxFrontOn { get; set; }
            public bool lightsAuxRoofOn { get; set; }
            public bool lightsBeaconOn { get; set; }
            public bool lightsBrakeOn { get; set; }
            public bool lightsReverseOn { get; set; }
            public Placement placement { get; set; }
            public Acceleration acceleration { get; set; }
            public Head head { get; set; }
            public Cabin cabin { get; set; }
            public Hook hook { get; set; }
        }

        public class Placement2
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
            public float heading { get; set; }
            public float pitch { get; set; }
            public float roll { get; set; }
        }

        public class Trailer
        {
            public bool attached { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public float mass { get; set; }
            public float wear { get; set; }
            public Placement2 placement { get; set; }
        }

        public class Job
        {
            public int income { get; set; }
            public string deadlineTime { get; set; }
            public string remainingTime { get; set; }
            public string sourceCity { get; set; }
            public string sourceCompany { get; set; }
            public string destinationCity { get; set; }
            public string destinationCompany { get; set; }
        }

        public class Navigation
        {
            public string estimatedTime { get; set; }
            public int estimatedDistance { get; set; }
            public int speedLimit { get; set; }
        }

        public Game game { get; set; }
        public Truck truck { get; set; }
        public Trailer trailer { get; set; }
        public Job job { get; set; }
        public Navigation navigation { get; set; }
    }
}
