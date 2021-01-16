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
                                 
                                    DatabaseContract.Id,
                                    DatabaseWorkers.Name,
                                    DatabaseWorkers.Surname,
                                    DatabaseContract.dtStartContract,
                                    DatabaseContract.dtEndContract,
                                    DatabaseContract.Salary,
                                    DatabaseContract.Positions,
                                    DatabaseContract.TypeContracts,
                                    

                                });
            //dataGridViewContracts.AutoResizeColumns();
            dataGridViewContracts.DataSource = empContracts.ToList();          
            dataGridViewContracts.Columns["dtStartContract"].HeaderText = "Data podpisania";
            dataGridViewContracts.Columns["dtEndContract"].HeaderText = "Data wygaśnięcia umowy";
            dataGridViewContracts.Columns["Salary"].HeaderText = "Wynagrodzenie";
            dataGridViewContracts.Columns["Positions"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["TypeContracts"].HeaderText = "Stanowisko";
            dataGridViewContracts.Columns["Name"].HeaderText = "Imie ";
            dataGridViewContracts.Columns["Surname"].HeaderText = "Nazwisko ";
           
            dataGridViewContracts.Columns["Id"].Visible = false;

            //dataGridViewContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



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
                DatabaseHRContracts.SubmitChanges();  
                LoadContracts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            int rowIndex = dataGridViewContracts.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewContracts.Rows[rowIndex];
           
            int index =Convert.ToInt32(selectedRow.Cells[0].Value);

            ContratcsEdit ce = new ContratcsEdit(MainForm.DatabaseHRDataConnection, index);
             ce.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void ContractsForm_Resize(object sender, EventArgs e)
        {
            int x = this.Size.Width;
            int y = this.Size.Height;
            dataGridViewContracts.Size = new Size(x, y);
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            //int x = this.Size.Width;
            //int y = this.Size.Height;
            //this.dataGridViewContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
    }
}
