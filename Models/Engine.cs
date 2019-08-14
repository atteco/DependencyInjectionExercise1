using DependencyInjectionExercise1.Interfaces;

namespace DependencyInjectionExercise1.Models
{
    public class Engine : IEngine
    {
        public bool running {get; set;}

        public Engine()
        {
            running = false;
        }

    }
}