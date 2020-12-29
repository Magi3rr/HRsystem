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

        

        public SalaryForm()
        {
            InitializeComponent();
           // LoadSalary();

        }

        public void LoadSalary()
        {


           var stu = (from DatabaseHRSalary in MainForm.DatabaseHRDataConnection.TypeContracts join DatabaseHRConctract in MainForm.DatabaseHRDataConnection.Contract on DatabaseHRSalary.Id equals DatabaseHRConctract.Id

                       select new
                      {
                         DatabaseHRSalary.typeContract,
                         DatabaseHRSalary.Id,
                         DatabaseHRConctract.dtStartContract,
                         DatabaseHRConctract.dtEndContract
                       });

            dataGridViewSalary.DataSource = stu.ToList();



        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadSalary();
        }
    }
}
