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
        /*

            if (numericUPWynagrodzenie.Value < 99)
            {
                MessageBox.Show("Wynagrodzenie jest mniejsze od bazowej kwoty");

            }
            else if (weryfikacja()== false)
            {
                newContract.IdTypUmowy = 1;
                if (radioButtonUOP.Checked)
                {

                    newContract.IdTypUmowy = 2;
                }
                newContract.DataRozpoczęcia = dtBirth.Value;
                newContract.DataZakończenia = dtBirth.Value;
                newContract.IdStanowisko = 1;
                if (radioButtonKierownik.Checked)
                {
                    newContract.IdStanowisko = 2;
                }
                newContract.Wynagrodzenie = numericUPWynagrodzenie.Value;
                //newContract.IdPracownik =
            }
        */
            newContract.IdContractType = 1;
            if (radioButtonUOP.Checked)
            {

                newContract.IdContractType = 2;
            }
            newContract.dtStartContract = dtBirth.Value;
            newContract.dtEndContract = dtBirth.Value;
            newContract.IdPosition = 1;
            if (checkBoxKier.Checked)
            {
                newContract.IdPosition = 2;
            }
            newContract.Salary = numericUPWynagrodzenie.Value;
            newContract.IdWorker = 30; //wymaga dodania listy rozwijanej typu 


            MainForm.DatabaseHRDataConnection.Contract.InsertOnSubmit(newContract);
            MainForm.DatabaseHRDataConnection.SubmitChanges();
            var workersForm = Application.OpenForms.OfType<WorkersForm>().Single();
            workersForm.LoadContracts();


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


        private void label5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
