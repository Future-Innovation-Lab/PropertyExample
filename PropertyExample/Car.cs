using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    internal class Car
    {
        public string Model { get; set; }

        public int CurrentSpeed
        {
            get { 
                return GetCurrentSpeed(); 
            }
            set {
                SetCurrentSpeed(value);
             
            }
        }





        private int _currentSpeed;
        private string _make;
        //private string _model;
        private int _topSpeed;
       // public int CurrentSpeed;


        public Car(string model, string make, int topSpeed)
        {
            _make = make;
            Model = model;
            _topSpeed = topSpeed;
        }

        public void SetCurrentSpeed(int currentSpeed)
        {
            if (currentSpeed > _topSpeed)
            {
                _currentSpeed = _topSpeed;
            }
            else
                _currentSpeed = currentSpeed;
        }

        public int GetCurrentSpeed()
        {
            return _currentSpeed;
        }

    }
}
