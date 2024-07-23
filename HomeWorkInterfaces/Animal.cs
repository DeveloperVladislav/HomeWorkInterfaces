using HomeWorkInterfaces.Auto;
using HomeWorkInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces
{
	public interface IDeepCloneable
	{
		object DeepClone();
	}
	public class Animal: ICloneable
	{
		public PetrolCar Car { get; set; }
		public string Name { get; set; }
		public int Weight { get; set; }

		public Animal(string name, int weight)
		{
			Name = name;
			Weight = weight;
			
		}
		public Animal(string name, int weight, PetrolCar car)
		{
			Name = name;
			Weight = weight;
			Car = car;
		}


		public object Clone()
		{
			return MemberwiseClone(); //new Animal(Name, Weight);
		}

		public object DeepClone() => new Animal(Name, Weight, new PetrolCar(Car.Name));
		
	}
}
