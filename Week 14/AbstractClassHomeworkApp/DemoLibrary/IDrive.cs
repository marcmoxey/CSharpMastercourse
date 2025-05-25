using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IDrive
    {
        void Start();
        void Stop();
        void Accelerate(int speed);
        void Brake(int speed);
        void Turn(string direction);
    }
}
