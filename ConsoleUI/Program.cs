using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Repository;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IBaseService<Car> carManager = new CarManager(new EfCarDal());
            //((CarManager)carManager).GetAll();
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //carManager.Add(new Car() { BrandId = 6, ColorId = 3, ModelYear = "2009", DailyPrice = 60, Descriptions = "Manual Gasoline" });
            //carManager.Delete(new Car() { Id = 6 });
            //brandManager.Add(new Brand { BrandName = "Honda" });
            
            //AllCars(carManager,brandManager,colorManager);
            //AllCarsByPrice(carManager, brandManager, colorManager,100,160);
            //AllCarsByBrandId(carManager, brandManager, colorManager,2);
            //AllCarsByColorId(carManager, brandManager, colorManager,2);

            AllCarsDetails(carManager);




        }

        #region Ders 9 Ödev

        private static void AllCarsDetails(CarManager carManager)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar Detail List Filter : No Filter Selected\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    car.BrandName,
                    car.ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");


        }
        #endregion

        #region Ders 8 Ödev
        private static void AllCarsByColorId(CarManager carManager, BrandManager brandManager, ColorManager colorManager, int id)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar List Filter : ColorId[{0}]\n", id);
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByColorId(id))
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCarsByBrandId(CarManager carManager, BrandManager brandManager, ColorManager colorManager, int id)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar List Filter : BrandId[{0}]\n", id);
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByBrandId(id))
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCarsByPrice(CarManager carManager, BrandManager brandManager, ColorManager colorManager, decimal min, decimal max)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar List Filter : Price [min: {0},max: {1}]\n", min, max);
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAllByDailyPrice(min, max))
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCars(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar List Filter : No Filter Selected\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAll())
            {
                //Console.WriteLine($"{car.Id}\t{brandManager.GetById(car.BrandId).BrandName}\t\t{colorManager.GetById(car.ColorId).ColorName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");

        } 
        #endregion
    }
}
