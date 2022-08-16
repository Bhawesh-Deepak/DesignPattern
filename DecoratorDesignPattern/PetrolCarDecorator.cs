using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.Manufacture();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is MarutiCar)
            {
                MarutiCar marutiCar = (MarutiCar)car;
                marutiCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}
