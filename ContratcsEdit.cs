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
    public partial class ContratcsEdit : Form
    {
        DatabaseHRDataContext DatabaseHRContracts;
        Contract w;

        public ContratcsEdit(DatabaseHRDataContext DatabaseHRContracts, int id)
        {
            InitializeComponent();

            this.DatabaseHRContracts = DatabaseHRContracts;
            w = DatabaseHRContracts.Contract.Single(x => x.Id == id);
            dateTimeRozp.Value = w.dtStartContract;
            dateTimeKonc.Value = w.dtEndContract;
            numericUPWynagrodzenie.Text= w.Salary.ToString();
            if (w.IdPosition==1)
            {
                dateTimeRozp.Value = w.dtStartContract;
                dateTimeKonc.Value = w.dtEndContract;
            }
            


        }

        public ContratcsEdit()
        {
            InitializeComponent();
        }

        private void btnAddContrats_Click(object sender, EventArgs e)
        {
            // w.dtEndContract = dateTimeRozp.Format();
            /*w.dtStartContract = dateTimeKonc.Value();
            if (radioButtonUZ.Checked)
            {
                w.IdContractType = 1;
            }
            else
            {
                w.IdContractType = 2; 
            }

            if (checkBoxKier.Checked)
            {
                w.IdPosition = 1;
            }
            else
            {
                w.IdPosition = 2;
            }
           // w.Salary = numericUPWynagrodzenie.Value(); // Value
           //w.Worker - lista rozwijana z bazy
            */
            DatabaseHRContracts.SubmitChanges();
        }

        private void ContratcsEdit_Load(object sender, EventArgs e)
        {
            cbBoxPositionType.DataSource = MainForm.DatabaseHRDataConnection.Positions;
            cbBoxContractType.DataSource = MainForm.DatabaseHRDataConnection.TypeContracts;
            cbBoxWorkerName.DataSource = MainForm.DatabaseHRDataConnection.Worker;
        }
    }
}
