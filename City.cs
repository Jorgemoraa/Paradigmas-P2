using System;

namespace Practice1
{
	public class City: IMessageWritter
	{
		private string cityName;
		private List<Taxi> taxiList;
		public City(string cityName)
		{
			this.cityName = cityName;
			this.taxiList = new List<Taxi>();
		}
			
		public void CreatePoliceStation()
		{
			PoliceStation policeStation = new PoliceStation();
			Console.WriteLine(WriteMessage("Created Police Station"));
		}

		public void CreateTaxiLicence(Taxi taxi)
		{ 
			taxiList.Add(taxi);
			Console.WriteLine(WriteMessage($"Created licence for the taxi with plate {taxi.GetPlate()}"));
		}

		public void RemoveTaxiLicence(Taxi taxi)
		{
			taxiList.Remove(taxi);
            Console.WriteLine(WriteMessage($"Removed licence for the taxi with plate {taxi.GetPlate()}"));
        }

		public void GetTaxiList()
		{
			Console.WriteLine(WriteMessage("List of taxis with licence:"));
            foreach (Taxi taxi in taxiList)
				Console.WriteLine(taxi.GetPlate());
		}

		public string GetCityName()
		{
			return cityName;
		}
		public string WriteMessage(string message)
		{
			return $"{cityName}: {message}";
		}
	}
}