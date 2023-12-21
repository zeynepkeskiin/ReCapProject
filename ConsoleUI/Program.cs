using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CarTest();
            RentalAdd();



             static void RentalAdd()
            {
                RentalManager rentalManager = new RentalManager(new EfRentalDal());


                var result = new Rental { Id = 3, CarId = 1, CustomerId = 1, RentDate = DateTime.Today, ReturnDate = null };
                var result2 = rentalManager.Add(result);
                if (result2.Success == true)
                {
                    Console.WriteLine(Messages.BuyAccepted);
                }
                else
                {
                    Console.WriteLine(Messages.BuyReject);
                }
            }

             static void UserAdd()
            {
                UserManager userManager = new UserManager(new EfUserDal());
                var userlList = new List<User>
         {  new User { Id = 1, FirstName = "Enes", LastName = "Eroglu", Email = "firnox61@gmail.com", Password = "password" },
             new User { Id = 2,FirstName = "zafer", LastName = "Eroglu", Email = "firnox61@gmail.com", Password = "password"},
             new User { Id = 3,FirstName = "kelime", LastName = "marat", Email = "sadx61@gmail.com", Password = "sadsa"},
             new User { Id = 4,FirstName = "cevdet", LastName = "karat", Email = "fgggox61@gmail.com", Password = "safdaf"},
             new User { Id = 5,FirstName = "salih", LastName = "zarat", Email = "fsadas1@gmail.com", Password = "fdsgfdg"},
             new User { Id = 6,FirstName = "hasan", LastName = "tarat", Email = "firsd@gmail.com", Password = "passwgrdgfrdord"},
         };
                //var result = new User { Id = 2, FirstName = "zafer", LastName = "Eroglu", Email = "firnox61@gmail.com", Password = "password" };
                //var result = new User { Id = 1, FirstName = "Enes", LastName = "Eroglu", Email = "firnox61@gmail.com", Password = "password" };
                foreach (var users in userlList)
                {
                    userManager.Add(users);
                }



            }

             static void Ekle()
            {
                CarManager carManager2 = new CarManager(new EfCarDal());
                var result = new Car { CarId = 4, BrandId = 1, CarName = "Pegout", DailyPrice = 325, ColorId = 1, ModelYear = 2001 };
                carManager2.Add(result);
            }

            static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                var result = carManager.GetCarDetails();
                if (result.Success == true)
                {

                    foreach (var car in result.Data)
                    {
                        Console.WriteLine("Araba:" + car.CarName + "Marka:" + car.BrandName + "Renk:" + car.ColorName + "Fiyat:" + car.DailyPrice);
                    }
                    Console.WriteLine(result.Message);
                }

                 ;/*

                  }

                  private static void CarTest()
                  {
                      CarManager carmanager = new CarManager(new EfCarDal());
                      var result = carmanager.GetCarDetails();
                      if (result.Success == true) { 
                      foreach (var Car in carmanager.GetCarDetails().Data)
                      {

                          Console.WriteLine(Car.CarName + "/" + Car.BrandName);

                      }
                      }
                      else
                      {
                          Console.WriteLine(result.Message);
                      }*/


            }
        }
    }
}