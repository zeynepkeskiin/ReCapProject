using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarContext context = new CarContext())
            {

            
                var result = from r in context.Rentals
                         join g in context.Customers
                         on r.CustomerId equals g.UserId
                         join c in context.Cars
                         on r.CarId equals c.CarId
                         select new RentalDetailDto
                         {
                             Id = r.Id,
                             CarId = c.CarId,
                             CustomerId = g.UserId
                         ,
                             RentDate = r.RentDate,
                             ReturnDate = r.ReturnDate
                         
                         };
            return result.ToList();
        }
    }
    }
}
