using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        // Fields
        private string _year;
        private string _make;
        private int _speed;

        // Constructor
        public Car()
        {
            _year = "";
            _make = "";
            _speed = 0;
        }

        // Year property
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Speed property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        // Accelerate Method
        public void Accelerate(int speedUp)
        {
            _speed += speedUp;
        }

        // Brake Method
        public void Brake(int slowDown)
        {
            _speed -= slowDown;
        }
    }
}
