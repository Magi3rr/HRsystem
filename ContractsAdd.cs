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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            Contract newContract = new Contract();

            newContract.TypeContracts= cbBoxContractType.SelectedItem as TypeContracts;
            newContract.dtStartContract = dtBirth.Value;
            newContract.dtEndContract = dtBirth.Value;
            newContract.Positions = cbBoxPositionType.SelectedItem as Positions;
            newContract.Salary = numericUPWynagrodzenie.Value;
            newContract.Worker = cbBoxWorker.SelectedItem as Worker;

           
            MainForm.DatabaseHRDataConnection.Contract.InsertOnSubmit(newContract);
            MainForm.DatabaseHRDataConnection.SubmitChanges();
            var contractsForm = Application.OpenForms.OfType<ContractsForm>().Single();
            contractsForm.LoadContracts();


            Close();



        }



        private void ContractsAdd_Load(object sender, EventArgs e)
        {
          
            cbBoxPositionType.DataSource = MainForm.DatabaseHRDataConnection.Positions;
            cbBoxContractType.DataSource = MainForm.DatabaseHRDataConnection.TypeContracts;
            cbBoxWorker.DataSource = MainForm.DatabaseHRDataConnection.Worker;

            /*
            var empContracts = (from DatabaseContract in MainForm.DatabaseHRDataConnection.Contract
                                join
                                DatabaseWorkers in MainForm.DatabaseHRDataConnection.Worker on
                                DatabaseContract.IdWorker equals DatabaseWorkers.Id
                                select new
                                {
                                    DatabaseWorkers.Name,
                                    DatabaseWorkers.Surname,
                                });


            cbBoxWorker.DataSource = empContracts;

            */
        }
    }
}
