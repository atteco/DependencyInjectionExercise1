using DependencyInjectionExercise1.Interfaces;

namespace DependencyInjectionExercise1.Models
{
    public class Engine : IEngine
    {
        public bool running {get; set;} = false;

        public Engine()
        {
            running = false;
        }

        public Engine(bool start)
        {
            running = start;
        }

    }
}