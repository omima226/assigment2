using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehicle_Control_System
{
    public abstract class Vehicle
    {
        public void Start()
        {
            Console.WriteLine($"{GetType().Name} is starting");
        }
        public void Stop()
        {
            Console.WriteLine($"{GetType().Name} is stopping");
        }
        public abstract string Describe();
    }
}
