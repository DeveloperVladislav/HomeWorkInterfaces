using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces.Auto
{
    public class PetrolCar : TransportCar<int>
    {
		public string Name { get; set; }
		public PetrolCar(string name)
		{
			Name = name;
		}

		public override void Accelerate(int accelerationValue)
		{
			Speed += accelerationValue;
			Console.WriteLine($"The petrol engine is roaring! Current speed: {Speed}");
		}

		public override void Brake(int brakingValue)
		{
			Speed = Math.Max(0, Speed - brakingValue);
			Console.WriteLine($"Petrol engine brakes! Current speed: {Speed}");
		}
	}
}
