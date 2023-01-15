using System;
using System.Collections.Generic;
using System.Threading;

namespace InterfaceHomework
{
    class Program
    {
        public interface IRobot // Пункт 1.
        {
            public string GetInfo();
            public List<string> GetComponents();
            public string GetRobotType()
            {
                return "I am a simple robot";
            }
        }

        public interface IChargeable // Пункт 2.
        {
            void Charge();
            string GetInfo();
        }

        public interface IFlyingRobot : IRobot // Пункт 3.
        {
            new string GetRobotType()
            {
                return "I am a flying robot";
            }
        }

        static void Main(string[] args)
        {
            Quadcopter copter = new Quadcopter();
            Plane myPlane = new Plane();
            Battery myBattery= new Battery();
            IFlyingRobot copter1 = new Quadcopter();
            IRobot copter2 = new Transformer();

            copter.Charge();
            foreach (var item in copter.GetComponents())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");

            Console.WriteLine(copter1.GetRobotType());
            Console.WriteLine(copter2.GetRobotType());

        }

        public class Quadcopter : IFlyingRobot, IChargeable
        {
            List<string> List_components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

            public void Charge()
            {
                Console.WriteLine("Charging...");
                Thread.Sleep(3000);
                Console.WriteLine("Charged!");
            }

            public List<string> GetComponents()
            {
                return List_components;
            }

            public string GetInfo()
            {
                throw new NotImplementedException();
            }

        }

        public class Transformer : IRobot
        {
            public List<string> GetComponents()
            {
                throw new NotImplementedException();
            }

            public string GetInfo()
            {
                throw new NotImplementedException();
            }
        }

        public class Plane : IFlyingRobot
        {
            public List<string> GetComponents()
            {
                throw new NotImplementedException();
            }

            public string GetInfo()
            {
                throw new NotImplementedException();
            }
        }

        public class Battery : IRobot
        {
            public List<string> GetComponents()
            {
                throw new NotImplementedException();
            }

            public string GetInfo()
            {
                throw new NotImplementedException();
            }
        }
    }
}