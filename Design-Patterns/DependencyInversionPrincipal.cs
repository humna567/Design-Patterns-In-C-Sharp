//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPatterns
//{
//    // wimplement interface becoz switch and bulb have same prop

//    interface ILightSource
//    {
//        bool IsOn { get; }

//        void TurnOn();

//        void TurnOff();
//    }

//    internal class LightBulb : ILightSource()
//    {
//        public bool IsOn => throw new NotImplementedException();

//        public void TurnOn()
//        {
//            Console.WriteLine("Light bulb turned on.");
//        }

//        public void TurnOff()
//        {
//            Console.WriteLine("Light bulb turned off.");
//        }
//    }

//    class Switch
//    {
//        private ILightSource lightSource;

//        public Switch(ILightSource source)
//        {
//            lightSource = source;
//        }

//        public void Operate()
//        {
//            if (lightSource != null)
//            {
//                if (lightSource.IsOn)
//                    lightSource.TurnOff();
//                else
//                    lightSource.TurnOn();
//            }
//        }
//    }

   
    
//}
