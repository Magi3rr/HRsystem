﻿using System;
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
           // w = DatabaseHRContracts.Contract.Single(x => x.Id == id);
           // dateTimeRozp.Value = w.dtStartContract;
           // dateTimeKonc.Value = w.dtEndContract;
          //  numericUPWynagrodzenie.Value = w.Salary;
           //


        }

        public ContratcsEdit()
        {
            InitializeComponent();
        }

        private void ContratcsEdit_Load(object sender, EventArgs e)
        {
            cbBoxPositionType.DataSource = MainForm.DatabaseHRDataConnection.Positions;
            cbBoxContractType.DataSource = MainForm.DatabaseHRDataConnection.TypeContracts;
            cbBoxWorkerName.DataSource = MainForm.DatabaseHRDataConnection.Worker;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            ////
            DatabaseHRContracts.SubmitChanges();
            Close();
        }
    }
}
