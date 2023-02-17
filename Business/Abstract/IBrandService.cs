using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetAllByCategory(int id);
        List<Brand> GetByUnitPrice(decimal min, decimal max);
        List<Brand> GetBrandsByBrandId(int id);
        List<Brand> GetBrandsByColorId(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetById(int brandId);
    }
}
