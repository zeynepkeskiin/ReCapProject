﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.IdentityModel.Tokens;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=20,CarName="MAZDA"},
            new Car {CarId=2,BrandId=2,ColorId=1,ModelYear=2015,DailyPrice=25,CarName="AUDİ"},
                new Car {CarId=3,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=30,CarName="MERCEDES"},
                new Car {CarId=4,BrandId=4,ColorId=2,ModelYear=2020,DailyPrice=40,CarName="TOGG"},
                new Car {CarId=5,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=25,CarName="AUDİSLX"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId=car.CarId;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.CarName=car.CarName;
             
            carToUpdate.DailyPrice=car.DailyPrice;
            
        }
    }
}