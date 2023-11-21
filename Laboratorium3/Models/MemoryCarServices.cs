using Laboratorium3.Models;

namespace Laboratorium3.Models
{
    public class MemoryCarServices : ICarService
    {
        private readonly Dictionary<int, Car> _cars = new Dictionary<int, Car> ()
       {
            {1,new Car() {Id=1,Model="Astra",Manufacturer="Opel", EngineCapacity="23l", EngineType="Benzyna", RegistrationNumber="KRA84602", Owner="Iza"}},
            {2,new Car() {Id=2,Model="Megane",Manufacturer="Renault", EngineCapacity="32l", EngineType="Benzyna", RegistrationNumber="KRA1KOX", Owner="Iza"}},

        };
private int _id=3;
        public void Add(Car car)
        {
            car.Id= _id++;
            _cars[car.Id] = car;
        }

        public void DeleteById(Car car)
        {
            _cars.Remove(car.Id);
        }

        public List<Car> FindAll()
        {
            return _cars.Values.ToList();
        }

        public Car? FindById(int id)
        {
            return _cars[id];
        }

        public void Update(Car car)
        {
            _cars[car.Id] = car;
        }
    }
}
