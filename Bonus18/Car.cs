using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {

        #region variables
        private string make;
        private string model;
        private int year;
        private double price;
        #endregion

        #region properties
        public string CarMake
        {
            set
            {
              make = value;
            }

            get
            {
                return make;
            }

        }

        public string CarModel
        {
            set
            {
                model = value;
            }

            get
            {
                return model;
            }
        }

        public int CarYear
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }

        public double CarPrice
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }




        #endregion

        #region constructors
        public Car()
        {
            make = "Ford";
            model = "Fiesta";
            year = 2016;
            price = 20000.00;
        }

        public Car(string makeInput,
            string modelInput,
            int yearInput,
            double priceInput)
        {
            make = makeInput;
            model = modelInput;
            year = yearInput;
            price = priceInput;
        }
        #endregion 








    }
}
