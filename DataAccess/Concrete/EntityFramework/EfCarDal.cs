using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {

                {
                    var result = from c in context.Cars
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join g in context.Colors
                                   on c.ColorId equals g.ColorId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     CarName = c.CarName,
                                     BrandName = b.BrandName,
                                     ColorName = g.ColorName,
                                     DailyPrice = c.DailyPrice
                                 };
                    return result.ToList();

                }
            }

        
        


            
            }
        }
    }
