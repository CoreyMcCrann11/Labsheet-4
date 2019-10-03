using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet_4
{
    class Car
    {
        private string make;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        private string currentspeed;

        public string currentSpeed
        {
            get
            {
                return currentspeed;
            }

            set
            {
                currentspeed = value;
            }

        }

        private string enginesize;

        public string engineSize
        {
            get
            {
                return enginesize;
            }

            set
            {
                enginesize = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Car Make : " + make + "Car Model " + model + "Current Speed " + currentspeed + "Engine Size " + enginesize;
        }






    }
}
