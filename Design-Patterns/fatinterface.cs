using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    using System;

    // Interface Segregation Principle (Without adhering to ISP)

    // Interface that violates ISP by including unrelated methods
    interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();
    }

    // Concrete class implementing the IWorker interface

  
    class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Worker is sleeping.");
        }
    }

   
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Robot does not eat.");
        }

        public void Sleep()
        {
            Console.WriteLine("Robot does not sleep.");
        }
    }

    

}
