using HomeWorkInterfaces.Auto;
using HomeWorkInterfaces.Interfaces;
using HomeWorkInterfaces.TV;
using System.Drawing;

namespace HomeWorkInterfaces
{
	public class Program
	{
		static void Main(string[] args)
		{/*
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
			electricCar.StopEngine();*/



			Animal lion = new Animal("Lion", 100);
			Animal cat = lion;
			cat.Name = "Cat";
			Console.WriteLine($"Name = {lion.Name}, Weight = {lion.Weight}");// изменится и будет Cat, т к lion указывает на один и тот же объект в памяти

			Animal lion1 = new Animal("Lion", 100);
			Animal cat1 = (Animal)lion1.Clone(); //поверхностное копирование
			cat1.Name = "Cat";
			Console.WriteLine($"Name = {lion1.Name}, Weight = {lion1.Weight}");// будет указывать на новый объект, но со старым значением Lion
			Console.WriteLine("===================================================================");

			PetrolCar car = new PetrolCar("Bibi");
			Animal animal = new Animal(lion1.Name, lion1.Weight, car);
			Console.WriteLine($"Name = {lion1.Name}, Weight = {lion1.Weight}, Car = {lion1.Car.Name}");


			/*animal.Name = "Dog";
			animal.Car.Name = "Bip";
			Console.WriteLine();

			PetrolCar car = new PetrolCar("Bibi");
			Animal animal = (Animal)lion1.DeepClone();
			animal.Name = "Dog";
			animal.Car.Name = "Bip";
			Console.WriteLine();*/






		}
	}
}