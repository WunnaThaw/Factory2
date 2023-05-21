using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Toyota : Car
    {
        private readonly string _company;
        private string _model;
        private int _speed;

        public Toyota(string model, int speed)
        {
            _company = "Toyota";
            _model = model;
            _speed = speed;
        }

        public override string Company
        {
            get { return _company; }
        }

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public override int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
