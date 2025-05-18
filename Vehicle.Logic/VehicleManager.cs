using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vehicle.Logic
{
    public class VehicleManager 
    {
        #region Felder
        List<Vehicles> vehicles;
        #endregion

        #region Methoden
        public List<Vehicles> Import(string filename)
        {
            string line;
            List<Vehicles> newList = new List<Vehicles>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        if (vehicles[i] is Car)
                        {
                            string[] carData = line.Split(',');
                            int numberSeats = Convert.ToInt32(carData[0]);
                            Car c = new Car(numberSeats, carData[1], carData[2], carData[3], carData[4]);
                            newList.Add(c);
                        }

                        if (vehicles[i] is Truck)
                        {
                            string[] truckData = line.Split(',');
                            int payload = Convert.ToInt32(truckData[0]);
                            Truck c = new Truck(payload, truckData[1], truckData[2], truckData[3], truckData[4]);
                            newList.Add(c);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return newList;
        }

        public void Add(Vehicles v)
        {
            vehicles.Add(v);
        }

        public int ListLength()
        {
            return vehicles.Count;
        }

        public void Write2File(string filename)
        {
            try
            {
                FileStream fs;
                StreamWriter sw;

                fs = new FileStream(filename, FileMode.Create);
                sw = new StreamWriter(fs);

                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i] is Car)
                    {
                        Car c = (Car)vehicles[i];
                        sw.WriteLine(c.ToString());
                    }

                    if (vehicles[i] is Truck)
                    {
                        Truck t = (Truck)vehicles[i];
                        sw.WriteLine(t.ToString());
                    }
                }

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Vehicles> AllVehicles()
        {
            List<Vehicles> newList = new List<Vehicles>();
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i] is Car)
                {
                    Car c = (Car)vehicles[i];
                    newList.Add(c);
                }

                if (vehicles[i] is Truck)
                {
                    Truck t = (Truck)vehicles[i];
                    newList.Add(t);
                }
            }
            return newList;
        }

        public List<Vehicles> SearchedVehicles(string information)
        {
            List<Vehicles> newList = new List<Vehicles>();
            for (int i = 0; i < vehicles.Count; i++)
            {
                    if (vehicles[i] is Car)
                    {
                        Car c = (Car)vehicles[i];
                        if (c.Brand == information || c.ChassisNumber == information || c.Mark == information || c.Type == information)
                        {
                            newList.Add(c);
                        }
                    }

                    if (vehicles[i] is Truck)
                    {
                        Truck t = (Truck)vehicles[i];
                        if (t.Brand == information || t.ChassisNumber == information || t.Mark == information || t.Type == information)
                        {
                            newList.Add(t);
                        }
                    }
            }
            return newList;
        }
        #endregion

        #region Konstruktoren
        public VehicleManager()
        {
            vehicles = new List<Vehicles>();
        }
        #endregion
    }
}
