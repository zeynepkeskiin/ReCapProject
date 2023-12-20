using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());

            foreach (var Car in carmanager.GetCarDetails())
            {

                Console.WriteLine(Car.CarName + "/" + Car.BrandName);


            }


        }
    }
}