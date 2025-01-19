using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AReeder_Lab2
{
    public partial class Form1 : Form
    {
        //To save to database:
        //mdf file propeties, copy to output directory: copy if newer
        //server explorer, modify mdf file connection, choose mdf file in bin\debug folder
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDataSet.City);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form    
            this.Close();
            this.cityTableAdapter.Update(this.cityDataSet);
        }

        private void btnCityName_Click(object sender, EventArgs e)
        {
            //list cities by name
            this.cityTableAdapter.FillByCityName(this.cityDataSet.City);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //show average population, only number
            MessageBox.Show("Average population is: " + this.cityTableAdapter.AverageQry());
        }

        private void btnMaxPop_Click(object sender, EventArgs e)
        {
            //shows max population, only number
            MessageBox.Show("The maximum population is: " + this.cityTableAdapter.MaxPopulation());
        }

        private void btnMinPop_Click(object sender, EventArgs e)
        {
            //show min population, only number
            MessageBox.Show("The minimum population is: " + this.cityTableAdapter.MinPopulation());
        }

        private void btnPopAsc_Click(object sender, EventArgs e)
        {
            //list in ascending order by population
            this.cityTableAdapter.FillByAscPop(this.cityDataSet.City);
        }

        private void btnPopDesc_Click(object sender, EventArgs e)
        {
            //liat in descending order by population
            this.cityTableAdapter.FillByDescPop(this.cityDataSet.City);
        }
    }
}
