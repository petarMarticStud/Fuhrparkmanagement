using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Logic
{
   public class Truck : Vehicles
    {
        #region Felder u. Eigenschaften
        private int payload;

        public int Payload
        {
            get
            {
                return this.payload;
            }

            set
            {
                this.payload = value;
            }
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return "LKW:" + " " + this.mark + "," + " " + this.brand + "," + " " + this.type + "," + " "  + this.payload + "t" + " " + "Nutzlast";
        }
        #endregion

        #region Konstruktoren
        public Truck(int payload, string brand, string type, string chassisNumber, string mark) : base(brand, type, chassisNumber, mark)
        {
            this.payload = payload;
        }
        #endregion
    }
}
