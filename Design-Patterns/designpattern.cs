using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
   public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        
    }

   
   public interface IComputerBuilder
    {
        void SetCPU(string cpu);
        void SetRAM(string ram);
        void SetStorage(string storage);
        Computer Build();
    }

    
  public  class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU(string cpu) { _computer.CPU = cpu; }
        public void SetRAM(string ram) { _computer.RAM = ram; }
        public void SetStorage(string storage) { _computer.Storage = storage; }

        public Computer Build() { return _computer; }
    }

  public  class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU(string cpu) { _computer.CPU = cpu; }
        public void SetRAM(string ram) { _computer.RAM = ram; }
        public void SetStorage(string storage) { _computer.Storage = storage; }

        public Computer Build() { return _computer; }
    }

   
    public class ComputerShop
    {
        public Computer BuildComputer(IComputerBuilder builder)
        {
            builder.SetCPU("Intel i7");
            builder.SetRAM("16GB");
            builder.SetStorage("512 SSD");
            return builder.Build();
        }
    }

}
