using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAdoNet
{
    public partial class MainForm : Form
    {
        List<Car> carsList = null;
        DataTable carTable = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            carsList = new List<Car>
            {
                new Car{Color ="Black", Make ="BMW", PetName = "Beha" },
                new Car{Color ="White", Make ="BMW", PetName = "Whity" },
                new Car{Color ="Yellow", Make ="Suzuki", PetName = "Chucky" },
                new Car{Color ="Grey", Make ="Lada", PetName = "Horse" },
                new Car{Color ="Brown", Make ="Jilly", PetName = "Brownie" },
                new Car{Color ="Purple", Make ="BMW", PetName = "Beepep" },
                new Car{Color ="White", Make ="Subaru", PetName = "Lucky" },
                new Car{Color ="Blue", Make ="Mitsubishi", PetName = "Eye" },
                new Car{Color ="Orange", Make ="Crysler", PetName = "Dodge" },
                new Car{Color ="Indigo", Make ="Geep", PetName = "Jeep" }
            };
            CreateDatatable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateDatatable()
        {
            DataColumn carId = new DataColumn("ID", typeof(int));
            carId.AutoIncrement = true;
            carId.AutoIncrementSeed = 0;
            carId.AutoIncrementStep = 1;
            carId.ReadOnly = true;
            carId.AllowDBNull = false;
            carId.Unique = true;
            carId.Caption = "Car ID";
            DataColumn carMake = new DataColumn("Make", typeof(string));
            DataColumn carColor = new DataColumn("Color", typeof(string));
            DataColumn carName = new DataColumn("PetName", typeof(string));
            carName.Caption = "Pet Name";
            carTable.Columns.AddRange(new DataColumn[] { carId, carMake, carColor, carName });
            carTable.PrimaryKey = new DataColumn[] { carId };
            foreach (Car car in carsList)
            {
                DataRow newRow = carTable.NewRow();
                newRow["Make"] = car.Make;
                newRow["Color"] = car.Color;
                newRow["PetName"] = car.PetName;
                carTable.Rows.Add(newRow);
            }
            CarInventoryGridView.DataSource = carTable;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRowToRemote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
