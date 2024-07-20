using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces.Auto
{
	public class ElectricCar : TransportCar<double>
	{
		public override void Accelerate(double accelerationValue)
		{
			Speed += (int)accelerationValue;
			Console.WriteLine($"Electric motor is humming! Current speed: {Speed}");
		}

		public override void Brake(double brakingValue)
		{
			Speed = Math.Max(0, Speed - (int)brakingValue);
			Console.WriteLine($"Electric motor is slowing down! Current speed: {Speed}");
		}
	}
}
