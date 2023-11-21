namespace Laboratorium3.Models
{
    public interface ICarService
    {
         void Add(Car car);
         void Update(Car car);
         void DeleteById(Car car);
         Car? FindById(int id);
         List<Car> FindAll();
         




    }
}
