using System;

namespace Practice1
{
	public class PoliceStation
	{
		private List<PoliceCar> policeCarList;

		public PoliceStation()
		{
			policeCarList = new List<PoliceCar>();
		}


		public void AddPoliceCar(PoliceCar policeCar)
		{
			policeCarList.Add(policeCar);

		}

		public void NotificatePoliceCars(string taxiPlate)
		{
			foreach (PoliceCar policeCar in policeCarList)
			{
				policeCar.SetFollowedPlate(taxiPlate);
			}
		}
	}
}