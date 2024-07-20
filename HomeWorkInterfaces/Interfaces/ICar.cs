using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterfaces.Interfaces
{
    public interface ICar<T>
    {
        void StartEngine();
        void StopEngine();
        void Accelerate(T accelerationValue);
        void Brake(T brakingValue);
        void TurnLeft();
        void TurnRight();
    }
}
