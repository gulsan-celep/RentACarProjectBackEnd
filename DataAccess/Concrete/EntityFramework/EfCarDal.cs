using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             select new CarDetailDto 
                             { CarID=c.CarID, CarName = c.CarName, BrandName = b.BrandName, 
                               ColorName=cl.ColorName, DailyPrice=c.DailyPrice,
                               ModelYear = c.ModelYear, BrandId = b.BrandId, ColorId = c.ColorId
                             };
                return result.ToList();
            }
        }

    }
}
