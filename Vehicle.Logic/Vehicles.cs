using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Logic
{
   public abstract class Vehicles
    {
        #region Felder u. Eigenschaften
        protected string brand;
        protected string type;
        protected string chassisNumber;
        protected string mark;

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.brand = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public string ChassisNumber
        {
            get
            {
                return this.chassisNumber;
            }

            set
            {
                this.chassisNumber = value;
            }
        }

        public string Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                this.mark = value;
            }
        }
        #endregion

        #region Methoden
        public abstract override string ToString();
        #endregion

        #region Konstruktor
        public Vehicles(string brand, string type, string chassisNumber, string mark)
        {
            this.mark = mark;
            this.type = type;
            this.brand = brand;
            this.chassisNumber = chassisNumber;
        }
        #endregion
    }
}
