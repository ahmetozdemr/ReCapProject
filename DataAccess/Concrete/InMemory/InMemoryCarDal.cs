using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        //List<Car> _car;

        //public InMemoryCarDal()
        //{
        //    _car = new List<Car>
        //    {
        //       new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=120000,Description="Mercedes"},
        //       new Car{Id=2,BrandId=1,ColorId=3,ModelYear=19995,DailyPrice=150000,Description="Mercedes"},
        //       new Car{Id=3,BrandId=2,ColorId=5,ModelYear=2002,DailyPrice=520000,Description="Ferrari"},
        //       new Car{Id=4,BrandId=3,ColorId=9,ModelYear=2023,DailyPrice=180000,Description="Toyota"}
        //    };
        //}
        //public void Add(Car car)
        //{
        //    _car.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);

        //    _car.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _car;
        //}

        //public List<Car> GetById(int BrandId)
        //{
        //    return _car.Where(c => c.BrandId == BrandId).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
        //    carToUpdate.Id = car.Id;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
       // }
    }
}
