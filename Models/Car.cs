using DependencyInjectionExercise1.Interfaces;
namespace DependencyInjectionExercise1.Models 
{
    public class Car : ICar 
    {
        private IEngine _engine;
        public Car()
        {
        }

        public Car(IEngine e)
        {
            _engine = e;
        }

        public IEngine engine 
        {
            get { return _engine; }
            set { _engine = value; }
        }
    }
}