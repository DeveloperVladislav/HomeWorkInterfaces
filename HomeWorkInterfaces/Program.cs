using HomeWorkInterfaces.Auto;
using HomeWorkInterfaces.TV;

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
		}
	}
}