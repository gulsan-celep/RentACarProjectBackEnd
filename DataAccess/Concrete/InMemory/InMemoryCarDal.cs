using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Car>
            {
                new Car{CarID=1, BrandId=1,ColorId=1,DailyPrice=150000,CarName="BMW",ModelYear="2021"},
                new Car{CarID=2, BrandId=2,ColorId=2,DailyPrice=50000,CarName="Audi",ModelYear="2020"},
                new Car{CarID=3, BrandId=2,ColorId=3,DailyPrice=170000,CarName="Bugatti",ModelYear="2019"},
                new Car{CarID=4, BrandId=3,ColorId=2,DailyPrice=250000,CarName="Alfa Romeo",ModelYear="2001"},
                new Car{CarID=5, BrandId=3,ColorId=4,DailyPrice=550000,CarName="Buick",ModelYear="2004"},
                new Car{CarID=6, BrandId=4,ColorId=1,DailyPrice=1500000,CarName="Cadillac",ModelYear="1998"}
            };
        }

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public bool Any(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(p=>p.CarID==car.CarID);
            _carList.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _carList.Where(p=>p.CarID==carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsBrandAndColor(int brandId, int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(p=>p.CarID==car.CarID);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
