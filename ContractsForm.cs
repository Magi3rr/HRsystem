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
    public partial class ContractsForm : Form
    {


        DatabaseHRDataContext DatabaseHRContracts = new DatabaseHRDataContext();
        public ContractsForm()
        {
            InitializeComponent();
            LoadContracts();
        }

        public void LoadContracts()
        {

            var emp = (from x in DatabaseHRContracts.Contract select x).ToList();
            dataGridViewContracts.DataSource = emp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            ContractsAdd Adw = new ContractsAdd();
            Adw.Show();
            LoadContracts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //del
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //modyf
        }
    }
}
