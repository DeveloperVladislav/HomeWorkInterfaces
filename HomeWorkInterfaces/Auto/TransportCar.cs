using HomeWorkInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces.Auto
{
    public abstract class TransportCar<T> : ICar<T>
    {
        protected int Speed { get; set; } = 0;

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }

        public virtual void Accelerate(T accelerationValue)
        {
            Console.WriteLine($"The car is accelerating");
        }

        public virtual void Brake(T brakingValue)
        {
            Console.WriteLine($"The car is slowing down");
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("The car is turning left");
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("The car is turning right");
        }
    }
}
