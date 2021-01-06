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
            LoadSalary();

        }

        public void LoadSalary()
        {


            var stu = (from DatabaseHRSalary in MainForm.DatabaseHRDataConnection.TypeContracts
                       join DatabaseHRConctract in MainForm.DatabaseHRDataConnection.Contract on DatabaseHRSalary.Id equals DatabaseHRConctract.IdContractType

                       select new
                       {
                           DatabaseHRSalary.typeContract,
                           DatabaseHRSalary.Id,
                           DatabaseHRConctract.dtStartContract,
                           DatabaseHRConctract.dtEndContract,
                           DatabaseHRSalary.Contract

                       });

            dataGridViewSalary.DataSource = stu.ToList();
            dataGridViewSalary.Columns["dtStartContract"].HeaderText = "Data podpisania ";
            dataGridViewSalary.Columns["dtEndContract"].HeaderText = "Data wygaśnięcia umowy ";
            dataGridViewSalary.Columns["TypeContract"].HeaderText = "Rodzaj umowy ";
            dataGridViewSalary.Columns["Id"].Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
