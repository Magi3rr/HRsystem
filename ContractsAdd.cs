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
    public partial class ContractsAdd : Form
    {
       
        public ContractsAdd()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void workerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void workerBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseWr_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            Contract newContract = new Contract();

            newContract.IdContractType = cbBoxContractType.SelectedIndex;
            newContract.dtStartContract = dtBirth.Value;
            newContract.dtEndContract = dtBirth.Value;
            newContract.IdPosition = cbBoxPositionType.SelectedIndex;
            newContract.Salary = numericUPWynagrodzenie.Value;
           // newContract.Worker = cbBoxWorker.SelectedIndex;
            MainForm.DatabaseHRDataConnection.Contract.InsertOnSubmit(newContract);
            MainForm.DatabaseHRDataConnection.SubmitChanges();
            var contractsForm = Application.OpenForms.OfType<ContractsForm>().Single();
            contractsForm.LoadContracts();


            Close();



        }

        bool weryfikacja()
        {

            if (numericUPWynagrodzenie.Value.ToString() == "" || dtBirth.Value.ToString() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


      

        private void ContractsAdd_Load(object sender, EventArgs e)
        {
          
            cbBoxPositionType.DataSource = MainForm.DatabaseHRDataConnection.Positions;
            cbBoxContractType.DataSource = MainForm.DatabaseHRDataConnection.TypeContracts;
            cbBoxWorker.DataSource = MainForm.DatabaseHRDataConnection.Worker;
        }
    }
}
