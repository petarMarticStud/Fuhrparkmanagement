using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Logic
{
   public class Car : Vehicles
    {
        #region Felder u. Eigenschaften
        private int numberSeats;

        public int NumberSeats
        {
            get
            {
                return this.numberSeats;
            }

            set
            {
                this.numberSeats = value;
            }
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return "PKW:" + " " + this.mark + "," + " " + this.brand + "," + " " + this.type + "," + " " + this.numberSeats + " " + "Sitzplätze"; 
        }
        #endregion

        #region Konstruktoren
        public Car(int numberSeats, string brand, string type, string chassisNumber, string mark) : base(brand, type, chassisNumber, mark)
        {
            this.numberSeats = numberSeats;
        }
        #endregion
    }
}
