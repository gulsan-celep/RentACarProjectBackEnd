using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Bütün Arabaları getir. \n");
            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("CarName, BrandName, ColorName, DailyPrice. \n");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " +car.ColorName+ " / " + car.DailyPrice);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Bütün Renkleri getir. \n");

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("Bütün markaları getir. \n");

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

        }
    }
}
