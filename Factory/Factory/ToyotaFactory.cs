using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ToyotaFactory : CarFactory
    {
        private string _model;
        private int _speed;

        public ToyotaFactory(string model, int speed)
        {
            _model = model;
            _speed = speed;
        }
        public override Car GetCar()
        {
            return new Toyota(_model, _speed);
        }
    }
}
