using System;
using DependencyInjectionExercise1.Interfaces;
using DependencyInjectionExercise1.Models;

namespace DependencyInjectionExercise1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("tekee IEngine e1:stä . . .");
            IEngine e1 = new Engine();

            Console.WriteLine("tekee Car car1:stä Engine e1:llä . . .");
            Car car1 = new Car(e1);

            Console.WriteLine("car1 ja sen engine e1 . . . :");
            Console.WriteLine("car1 engine hash: " + car1.engine.GetHashCode());
            Console.WriteLine("car1 engine running:" + car1.engine.running);

            Console.WriteLine("yrittää käynnistää car1 enginen e1 . . . ");
            car1.engine.running = true;

            Console.WriteLine("car1 engine running:" + car1.engine.running);
            Console.ReadLine();
        }
    }
}
