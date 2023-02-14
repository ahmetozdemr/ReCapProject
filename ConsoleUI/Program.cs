using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {

        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
      
        }

        Console.WriteLine("*******************************");

        foreach (var car in carManager.GetAllByCategory(1))
        {
            Console.WriteLine(car.Description);
        }



        // CarManager carManager = new CarManager(new InMemoryCarDal());

        //foreach (var car in carManager.GetAll())
        //{
        //    Console.WriteLine(car.Description);
        //    Console.WriteLine(car.Id);
        //}

        //Console.WriteLine("********** After this Id 1 deleted *****************");

        //Car carToDelete = new Car { Id = 1 };

        //carManager.Delete(carToDelete);

        //foreach (var car in carManager.GetAll())
        //{
        //    Console.WriteLine(car.Description);
        //    Console.WriteLine(car.Id);
        //}

        //Console.WriteLine("********** After this Id 1 added *****************");

        //Car carToAdd = new Car { Id = 5,BrandId= 3,Description = "Volkswagen",ModelYear = 2022 };  

        //carManager.Add(carToAdd);

        //foreach (var car in carManager.GetAll())
        //{
        //    Console.WriteLine(car.Description);
        //    Console.WriteLine(car.Id);
        //}

        //Console.WriteLine("******************  Get By Id  ******************");

        //foreach (var item in carManager.GetById(3))
        //{
        //    Console.WriteLine(item.ModelYear);
        //}

        //Console.WriteLine("****************************************");



    }
}