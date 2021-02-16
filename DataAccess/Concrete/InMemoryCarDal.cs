using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car {CarId=1, BrandId=1, ColorId=3, DailyPrice=200, Description="Mazda 1.6 Motor, Full Paket, Benzin-Gaz, Otomatik Vites",ModelYear="2004" },
                new Car {CarId=2, BrandId=1, ColorId=1, DailyPrice=150, Description="Mazda 1.6 Motor, Full Paket, Benzin-Gaz, Düz Vites",ModelYear="2006" },
                new Car {CarId=3, BrandId=1, ColorId=2, DailyPrice=300, Description="Mazda 2.0 Motor, Full Paket, Dizel, Otomatik Vites",ModelYear="2008" },
                new Car {CarId=4, BrandId=2, ColorId=1, DailyPrice=250, Description="Opel 1.6 Motor, Full Paket, Benzin-Gaz, Otomatik Vites",ModelYear="2004" },
                new Car {CarId=5, BrandId=2, ColorId=3, DailyPrice=200, Description="Opel 2.0 Motor, Full Paket, Dizel, Düz Vites",ModelYear="2004" }
            };
            
        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            _Cars.Remove(carToDelete);
        }
        
        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetAllByCategory(int CarId)
        {
            return _Cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
