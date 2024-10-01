using System;

namespace Practice1
{
	public class Scooter : NoPlateVehicle
	{
		private static string typeOfVehicle = "Scooter";

		public Scooter(string typeOfVehicle) : base (typeOfVehicle)
		{
		}
	}
}