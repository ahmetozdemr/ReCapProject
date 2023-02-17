using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetAllByCategory(int id)
        {
            return _carDal.GetAll(p => p.CategoryId == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public void Add(Car car)
        {
            if(car.Description.Length>=2 && car.DailyPrice >0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("no enough condition ");
            }


        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

    

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }
    }
}
