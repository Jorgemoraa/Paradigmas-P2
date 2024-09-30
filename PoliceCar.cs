namespace Practice1
{
    public class PoliceCar : PlateVehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isChasing;
        private string followedPlate;
        private bool isPatrolling;
        private SpeedRadar speedRadar;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isChasing = false;
            followedPlate = "";
            speedRadar = new SpeedRadar();
        }

        public void UseRadar(PlateVehicle plateVehicle)
        {
            if (isPatrolling)
            {
                speedRadar.TriggerRadar(plateVehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool GetIsPatrolling()
        {
            return isPatrolling;
        }

        public void SetFollowedPlate(string plate)
        {
            if (isPatrolling)
            {
                if (!isChasing)
                {
                    isChasing = true;
                    followedPlate = plate;
                }
            }
        }



        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }
    }
}