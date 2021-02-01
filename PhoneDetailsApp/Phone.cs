using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDetailsApp
{
   public class Phone
    {

        //backing field
        private string _make;
        private string _model;
        private string _display;
        private string _storage;
        private decimal _price;

        public Phone(string[] tempPhone)
        {
            Make = tempPhone[0];
            Model = tempPhone[1];
            Display = tempPhone[2];
            Storage = tempPhone[3];
            Price = decimal.Parse(tempPhone[4]);
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public string Storage
        {
            get { return _storage; }
            set { _storage = value; }
        }

        public string Display
        {
            get { return _display; }
            set { _display = value; }
        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //public accessor
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

    }
}
