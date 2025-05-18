using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle.Logic;

namespace VehicleGUI
{
    public partial class Form1 : Form
    {
        VehicleManager vm;
        public Form1()
        {
            InitializeComponent();
            vm = new VehicleManager();
        }

        private void cbxCar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCar.Checked)
            {
                cbxTruck.Enabled = false;

                tbxPayload.Visible = false;
                tbxNumberSeats.Visible = true;
                tbxMark.Visible = true;
                tbxType.Visible = true;
                tbxBrand.Visible = true;
                tbxChassisNumber.Visible = true;
                tbxSearch.Visible = true;
                tbxFilename.Visible = true;

                lblPayload.Visible = false;
                lblNumberSeats.Visible = true;
                lblMark.Visible = true;
                lblType.Visible = true;
                lblBrand.Visible = true;
                lblChassisNumber.Visible = true;

                btnAdd.Visible = true;
                btnImport.Visible = true;
                btnSearch.Visible = true;
                btnSort.Visible = true;
                btnSave.Visible = true;
                btnAll.Visible = true;
                
            }

            if (cbxCar.Checked == false)
            {
                tbxSearch.Visible = false;
                tbxFilename.Visible = false;
                tbxPayload.Visible = false;
                tbxNumberSeats.Visible = false;
                tbxMark.Visible = false;
                tbxType.Visible = false;
                tbxBrand.Visible = false;
                tbxChassisNumber.Visible = false;

                lblPayload.Visible = false;
                lblNumberSeats.Visible = false;
                lblMark.Visible = false;
                lblType.Visible = false;
                lblBrand.Visible = false;
                lblChassisNumber.Visible = false;

                btnAdd.Visible = false;
                btnImport.Visible = false;
                btnSearch.Visible = false;
                btnSort.Visible = false;
                btnSave.Visible = false;
                btnAll.Visible = false;

                cbxTruck.Enabled = true;
            }
        }

        private void cbxTruck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTruck.Checked)
            {
                cbxCar.Enabled = false;

                tbxPayload.Visible = true;
                tbxNumberSeats.Visible = false;
                tbxMark.Visible = true;
                tbxType.Visible = true;
                tbxBrand.Visible = true;
                tbxChassisNumber.Visible = true;
                tbxSearch.Visible = true;
                tbxFilename.Visible = true;

                lblPayload.Visible = true;
                lblNumberSeats.Visible = false;
                lblMark.Visible = true;
                lblType.Visible = true;
                lblBrand.Visible = true;
                lblChassisNumber.Visible = true;

                btnAdd.Visible = true;
                btnImport.Visible = true;
                btnSearch.Visible = true;
                btnSort.Visible = true;
                btnSave.Visible = true;
                btnAll.Visible = true;
            }

            if (cbxTruck.Checked == false)
            {
                tbxSearch.Visible = false;
                tbxFilename.Visible = false;
                tbxPayload.Visible = false;
                tbxNumberSeats.Visible = false;
                tbxMark.Visible = false;
                tbxType.Visible = false;
                tbxBrand.Visible = false;
                tbxChassisNumber.Visible = false;

                lblPayload.Visible = false;
                lblNumberSeats.Visible = false;
                lblMark.Visible = false;
                lblType.Visible = false;
                lblBrand.Visible = false;
                lblChassisNumber.Visible = false;

                btnAdd.Visible = false;
                btnImport.Visible = false;
                btnSearch.Visible = false;
                btnSort.Visible = false;
                btnSave.Visible = false;
                btnAll.Visible = false;


                cbxCar.Enabled = true;
            }
        }

        private void ClearListBox()
        {
            lbxVehicles.Items.Clear();
        }


        private void lbxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxTruck.Checked)
            {
                int payload = Convert.ToInt32(tbxPayload.Text);
                Truck t = new Truck(payload, tbxBrand.Text, tbxType.Text, tbxChassisNumber.Text, tbxMark.Text);
                vm.Add(t);
                lbxVehicles.Items.Add(t.ToString());
            }

            if (cbxCar.Checked) 
            {
                int numberSeats = Convert.ToInt32(tbxNumberSeats.Text);
                Car c = new Car(numberSeats, tbxBrand.Text, tbxType.Text, tbxChassisNumber.Text, tbxMark.Text);
                vm.Add(c);
                lbxVehicles.Items.Add(c.ToString());
            }
            ClearAllFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                ClearListBox();
                string searchedText = tbxSearch.Text;
                List<Vehicles> newList = vm.SearchedVehicles(searchedText);
                for (int i = 0; i < newList.Count; i++)
                {                   
                        if (newList[i] is Car)
                        {
                            Car c = (Car)newList[i];
                            lbxVehicles.Items.Add(c.ToString());
                        }

                        if (newList[i] is Truck)
                        {
                            Truck t = (Truck)newList[i];
                            lbxVehicles.Items.Add(t.ToString());
                        }
                }          
        }

        private void ClearAllFields()
        {
            tbxBrand.Clear();
            tbxChassisNumber.Clear();
            tbxFilename.Clear();
            tbxMark.Clear();
            tbxNumberSeats.Clear();
            tbxPayload.Clear();
            tbxSearch.Clear();
            tbxType.Clear();    
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ClearListBox();
            List<Vehicles> newList = vm.AllVehicles();
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] is Car)
                {
                    Car c = (Car)newList[i];
                    lbxVehicles.Items.Add(c.ToString());
                }

                if (newList[i] is Truck)
                {
                    Truck t = (Truck)newList[i];
                    lbxVehicles.Items.Add(t.ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = tbxFilename.Text;
            vm.Write2File(@"C:\Users\Petar\Desktop\Fuhrparkmanagement\Software\files\" + file);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ClearListBox();
            string file = tbxFilename.Text;
            List<Vehicles> newList = vm.Import(@"C:\Users\Petar\Desktop\Fuhrparkmanagement\Software\files\" + file);
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] is Car)
                {
                    Car c = (Car)newList[i];
                    lbxVehicles.Items.Add(c.ToString());
                }

                if (newList[i] is Truck)
                {
                    Truck t = (Truck)newList[i];
                    lbxVehicles.Items.Add(t.ToString());
                }
            }
        }   
        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxVehicles.Sorted = true;  
        }
    }
}
