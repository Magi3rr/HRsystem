using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
   
    public partial class SalaryForm : Form
    {

        DatabaseHRDataContext DatabaseHRSalary = new DatabaseHRDataContext();


        public SalaryForm()
        {
            InitializeComponent();
            LoadSalary();

        }
        public void LoadSalary()
        {

            var sal = (from x in DatabaseHRSalary.Positions select x).ToList();
            dataGridViewSalary.DataSource = sal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSalary();
        }
    }
}
