using HomeWorkInterfaces.Auto;
using HomeWorkInterfaces.Interfaces;
using HomeWorkInterfaces.TV;
using System.Drawing;
using System.Collections.Generic;

namespace HomeWorkInterfaces
{
	public class Program
	{
		static void Main(string[] args)
		{
			RemoteControl remote = new RemoteControl();

			remote.PressButton1();
			remote.PressButton5();
			remote.PressUp();
			remote.PressRight();

			Console.WriteLine("-------------------------------------------------------------");


			PetrolCar petrolCar = new PetrolCar();
			ElectricCar electricCar = new ElectricCar();

			Console.WriteLine("\n--- Бензиновый автомобиль ---");
			petrolCar.StartEngine();
			petrolCar.Accelerate(20);
			petrolCar.TurnLeft();
			petrolCar.TurnRight();
			petrolCar.Brake(5);
			petrolCar.StopEngine();

			Console.WriteLine("\n--- Электромобиль ---");
			electricCar.StartEngine();
			electricCar.Accelerate(3.5);
			electricCar.TurnLeft();
			electricCar.TurnRight();
			electricCar.Brake(1.2);
			electricCar.StopEngine();

			Console.WriteLine("-------------------------------------------------------------");

			Animal lion = new Animal("Lion", 100);
			Animal cat = lion;
			cat.Name = "Cat";
			Console.WriteLine($"Name = {lion.Name}, Weight = {lion.Weight}");// изменится и будет Cat, т к lion указывает на один и тот же объект в памяти

			Animal lion1 = new Animal("Lion", 100);
			Animal cat1 = (Animal)lion1.Clone(); //поверхностное копирование
			cat1.Name = "Cat";
			Console.WriteLine($"Name = {lion1.Name}, Weight = {lion1.Weight}");// будет указывать на новый объект, но со старым значением Lion
			Console.WriteLine("===================================================================");

			PetrolCar car = new PetrolCar("Bip");
			Animal lion2 = new Animal("Lion", 100, car);
			Animal animal = (Animal)lion2.DeepClone();//глубокое копирование
			animal.Name = "Dog";
			animal.Car.Name = "Audi";
			animal.Weight = 1;
			Console.WriteLine($"Name = {lion2.Name}, Weight = {lion2.Weight}, Car = {lion2.Car.Name}");

			Console.WriteLine();
			Console.WriteLine("==================IComparable==========IComparer==================================");




			List<Person> people = new List<Person>()
			{
				new Person("Alice", 41),
			new Person("Tom", 37),
			new Person("Kate", 25)
		};
			people.Sort();
			Console.WriteLine("-IComparable-");
			foreach (Person person in people)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}

			Console.WriteLine();

			people.Sort(new PeopleComparer());
			Console.WriteLine("-IComparer-");
			foreach (Person person in people)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}



		}
	}
}