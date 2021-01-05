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

            var emp = (from x in MainForm.DatabaseHRDataConnection.Contract select x).ToList();
            dataGridViewContracts.DataSource = emp;
            dataGridViewContracts.Columns["dtStartContract"].HeaderText = "Data podpisania";
            dataGridViewContracts.Columns["dtEndContract"].HeaderText = "Data wygaśnięcia umowy";
            dataGridViewContracts.Columns["Salary"].HeaderText = "Wynagrodzenie";
            dataGridViewContracts.Columns["Positions"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["TypeContracts"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["IdContractType"].Visible = false;
            dataGridViewContracts.Columns["IdPosition"].Visible = false;
            dataGridViewContracts.Columns["IdWorker"].Visible = false;
            dataGridViewContracts.Columns["Id"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            ContractsAdd Adw = new ContractsAdd();
            Adw.Show();
            LoadContracts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony rekord?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = dataGridViewContracts.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridViewContracts.Rows[rowIndex];
                int index = Convert.ToInt32(selectedRow.Cells[0].Value);
               

                var query = from t in DatabaseHRContracts.Contract where t.Id == index select t;

                foreach (var t in query)
                {
                    DatabaseHRContracts.Contract.DeleteOnSubmit(t);
                }

                DatabaseHRContracts.SubmitChanges();  //nieobsługiwany wyjątek System.Data.Linq.ChangeConflictException
                LoadContracts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridViewContracts.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewContracts.Rows[rowIndex];
            int index = Convert.ToInt32(selectedRow.Cells[0].Value);

            //MainForm.DatabaseHRDataConnection.Contract
            ContratcsEdit ce = new ContratcsEdit(DatabaseHRContracts, index);
            //ContratcsEdit ce = new ContratcsEdit(MainForm.DatabaseHRDataConnection.Contract, index);
            ce.ShowDialog();
        }
    }
}
