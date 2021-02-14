using Business.Abstract;
using Business.Concrete;
using Business.UnitOfWork.Abstract;
using Business.UnitOfWork.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using DataAccess.Concrete.EntityFrameWork.Repository;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region oDEV10
            RentACarContext context = new RentACarContext();
            
            RentalManager rentalManager = new RentalManager(new EfRentalDal(context));
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(context));
            Rental rental = new Rental { Id = 18, CarId = 4/*, CustomerId = 2, IsRented = true, RentDate = null, ReturnDate = null*/ };
            
            var result= rentalManager.Delete(rental);
            context.SaveChanges();
            Console.WriteLine("{0} {1}", result.Success, result.Message);
            foreach (var r in customerManager.GetAll().Data)
            {

                Console.WriteLine("{0}\t{1}",
                    r.Id,
                    r.CompanyName
                    );
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");

            foreach (var r in rentalManager.GetAll().Data)
            {
                
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}",
                    r.Id,
                    r.CarId,
                    r.CustomerId,
                    r.RentDate,
                    r.ReturnDate,
                    r.IsRented
                    );
                
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");

            foreach (var r in rentalManager.GetRentalDetailsDto().Data)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                    r.Id,
                    r.BrandName,
                    r.UserFirstName + " " + r.UserLastName,
                    r.CompanyName,
                    r.RentDate,
                    r.ReturnDate,
                    r.IsRented
                    );
            }

            Console.WriteLine("\n-----------------------End of List---------------------------------");

            foreach (var r in rentalManager.GetRentalDetailsByCarIdDto(2).Data)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",

                    r.Id,
                    r.BrandName,
                    r.UserFirstName + " " + r.UserLastName,
                    r.CompanyName,
                    r.RentDate,
                    r.ReturnDate,
                    r.IsRented
                    );
            }

            #endregion


            //IUnitOfWork services = new UnitOfWork(context);
            //Car car = new Car  { BrandId = 6, ColorId = 3, ModelYear = 0, DailyPrice = 0, Descriptions = "f" };
            //Brand brand = new Brand { Id = 6, BrandName="sdsdsdsdsd" };



            //var result= services.CarService.Add(car);
            //Console.WriteLine("{0} {1}",result.Success, result.Message);

            //var result = services.BrandService.Delete(brand);
            //services.SaveChanges();
            //Console.WriteLine("{0} {1}", result.Success, result.Message);


            //foreach (var brand in services.BrandService.GetAll().Data)
            //{

            //    Console.WriteLine("{0}\t{1}",
            //        brand.Id,
            //        brand.BrandName);
            //}
            //Console.WriteLine("\n-----------------------End of List---------------------------------");
            //Console.WriteLine("\n-----------------------Colors--------------------------------------");
            //foreach (var color in services.ColorService.GetAll().Data)
            //{

            //    Console.WriteLine("{0}\t{1}",
            //        color.Id,
            //        color.ColorName);
            //}
            //Console.WriteLine("\n-----------------------End of List---------------------------------");
            //Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar Detail List Filter : No Filter Selected\n");
            //Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            //Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");
            //foreach (var car in services.CarService.GetCarDetails())
            //{

            //    Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
            //        car.Id,
            //        car.BrandName,
            //        car.ColorName,
            //        car.ModelYear,
            //        car.DailyPrice.ToString("##.## TL"),
            //        car.Descriptions);
            //}
            //Console.WriteLine("\n-----------------------End of List---------------------------------");
            //ICarService carManager = new CarManager(new EfCarDal(new RentACarContext()));
            //BrandManager brandManager = new BrandManager(new EfBrandDal(new RentACarContext()));
            //ColorManager colorManager = new ColorManager(new EfColorDal(new RentACarContext()));

            //carManager.Add(new Car() { BrandId = 6, ColorId = 3, ModelYear = "2009", DailyPrice = 60, Descriptions = "Manual Gasoline" });
            //carManager.Delete(new Car() { Id = 6 });
            //brandManager.Add(new Brand { BrandName = "Honda" });

            //AllCars(carManager,brandManager,colorManager);
            //AllCarsByPrice(carManager, brandManager, colorManager,100,160);
            //AllCarsByBrandId(carManager, brandManager, colorManager,2);
            //AllCarsByColorId(carManager, brandManager, colorManager,2);

            //AllCarsDetails(carManager);




        }

        #region Ders 9 Ödev

        private static void AllCarsDetails(CarManager carManager)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar Detail List Filter : No Filter Selected\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetCarDetails().Data)
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

            foreach (var car in carManager.GetAllByColorId(id).Data)
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).Data.BrandName,
                    colorManager.GetById(car.ColorId).Data.ColorName,
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

            foreach (var car in carManager.GetAllByBrandId(id).Data)
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).Data.BrandName,
                    colorManager.GetById(car.ColorId).Data.ColorName,
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

            foreach (var car in carManager.GetAllByDailyPrice(min, max).Data)
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).Data.BrandName,
                    colorManager.GetById(car.ColorId).Data.ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");
        }

        private static void AllCars(ICarService carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine(".:: My Rent A Car ::. \n\t\t\t\t\tCar List Filter : No Filter Selected\n");
            Console.WriteLine("Car ID \tBrand \t\tColor \t\tModel \t\tPrice \t\tDesc");
            Console.WriteLine("------ \t------ \t\t------ \t\t------ \t\t------ \t\t------");

            foreach (var car in carManager.GetAll().Data)
            {
                //Console.WriteLine($"{car.Id}\t{brandManager.GetById(car.BrandId).BrandName}\t\t{colorManager.GetById(car.ColorId).ColorName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    car.Id,
                    brandManager.GetById(car.BrandId).Data.BrandName,
                    colorManager.GetById(car.ColorId).Data.ColorName,
                    car.ModelYear,
                    car.DailyPrice.ToString("##.## TL"),
                    car.Descriptions);

            }
            Console.WriteLine("\n-----------------------End of List---------------------------------");

        } 
        #endregion
    }
}
