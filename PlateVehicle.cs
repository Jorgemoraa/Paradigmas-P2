using System;

namespace Practice1
{
	public class PlateVehicle : Vehicle
	{

		private string plate;
		public PlateVehicle(string typeOfVehicle, string plate) : base(typeOfVehicle)
		{
			this.plate = plate;
		}

		public string GetPlate()
		{
			return plate;
		}

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {plate}";
        }
    }
}