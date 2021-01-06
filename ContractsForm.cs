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

            var empContracts = (from DatabaseContract in MainForm.DatabaseHRDataConnection.Contract
                                join
                                DatabaseWorkers in MainForm.DatabaseHRDataConnection.Worker on
                                DatabaseContract.IdWorker equals DatabaseWorkers.Id
                                select new
                                {
                                    DatabaseWorkers.Id,
                                    DatabaseWorkers.Name,
                                    DatabaseWorkers.Surname,
                                    DatabaseContract.dtStartContract,
                                    DatabaseContract.dtEndContract,
                                    DatabaseContract.Salary,
                                    DatabaseContract.Positions,
                                    DatabaseContract.TypeContracts,
                                    

                                });
            dataGridViewContracts.AutoResizeColumns();
            dataGridViewContracts.DataSource = empContracts.ToList();          
            dataGridViewContracts.Columns["dtStartContract"].HeaderText = "Data podpisania";
            dataGridViewContracts.Columns["dtEndContract"].HeaderText = "Data wygaśnięcia umowy";
            dataGridViewContracts.Columns["Salary"].HeaderText = "Wynagrodzenie";
            dataGridViewContracts.Columns["Positions"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["TypeContracts"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["Name"].HeaderText = "Imie ";
            dataGridViewContracts.Columns["Surname"].HeaderText = "Nazwisko ";
           
             dataGridViewContracts.Columns["Id"].Visible = false;
            //dataGridViewContracts.Columns["IdWorker"].Visible = false;
           

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

                var getData = from st in MainForm.DatabaseHRDataConnection.Contract
                               join g in MainForm.DatabaseHRDataConnection.Worker on
                               st.IdWorker equals g.Id where st.Id.Equals(index)
                               select new { zmienna1=st, zmienna2=g };
                foreach (var t in getData)
                {

                    MainForm.DatabaseHRDataConnection.Contract.DeleteOnSubmit(t.zmienna1);
                    MainForm.DatabaseHRDataConnection.Worker.DeleteOnSubmit(t.zmienna2);

                }
             




                /*
                int rowIndex = dataGridViewContracts.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridViewContracts.Rows[rowIndex];
                int index = Convert.ToInt32(selectedRow.Cells[0].Value);
               

                var query = from t in MainForm.DatabaseHRDataConnection.Contract where t.Id == index select t;

                foreach (var t in query)
                {
                    DatabaseHRContracts.Contract.DeleteOnSubmit(t);
                }

              
                LoadContracts();
                */
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/26091759/using-linq-to-delete-multiple-rows-in-table-using-matching-key-from-related-tabl
            //https://www.codeproject.com/Questions/699533/how-to-delete-two-tables-data-with-together-in-lin
            int rowIndex = dataGridViewContracts.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewContracts.Rows[rowIndex];
            int index =Convert.ToInt32(selectedRow.Cells[0].Value);
            
            ContratcsEdit ce = new ContratcsEdit(MainForm.DatabaseHRDataConnection, index);
             ce.ShowDialog();
        }
    }
}
