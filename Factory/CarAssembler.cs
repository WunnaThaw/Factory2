using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarAssembler
    {
        public void AssembleCar(CarFactory factory)
        {
            Car car = factory.GetCar();
            Console.WriteLine("{0} {1} assembled successfully. Maximum speed is {2} mph", 
                car.Company, car.Model, car.Speed);
        }
    }
}
