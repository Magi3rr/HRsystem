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
    public partial class WorkersForm : Form
    {
        DatabaseHRDataContext DatabaseHRWorkers = new DatabaseHRDataContext();
        public WorkersForm()
        {
            InitializeComponent();
            LoadWorkers();
        }

       public void LoadWorkers()
        {          
            var emp = (from x in MainForm.DatabaseHRDataConnection.Worker select x).ToList();
            dataGridViewWorker.DataSource = emp;
            dataGridViewWorker.Columns["Name"].HeaderText = "Imię";
            dataGridViewWorker.Columns["Surname"].HeaderText = "Nazwisko";
            dataGridViewWorker.Columns["dtbirth"].HeaderText = "Data urodzenia";
            dataGridViewWorker.Columns["Genders"].HeaderText = "Płeć";
            dataGridViewWorker.Columns["Statuses"].HeaderText = "Status";
            dataGridViewWorker.Columns["Id"].Visible = false;
            dataGridViewWorker.Columns["IdSex"].Visible = false;
            dataGridViewWorker.Columns["IdStatus"].Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony rekord?","Usuwanie", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                int rowIndex = dataGridViewWorker.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridViewWorker.Rows[rowIndex];
                int index = Convert.ToInt32(selectedRow.Cells[0].Value);
                test.Text = index.ToString();

                var query = from t in DatabaseHRWorkers.Worker where t.Id == index select t;

                foreach (var t in query)
                {
                    DatabaseHRWorkers.Worker.DeleteOnSubmit(t);
                }
                DatabaseHRWorkers.SubmitChanges();
                LoadWorkers();
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            WorkerAdd Adw = new WorkerAdd(); 
            Adw.Show();
            LoadWorkers();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            var emp = (from x in DatabaseHRWorkers.Worker select x).ToList();
            dataGridViewWorker.DataSource = emp;
            //this.WindowState = FormWindowState.Maximized;
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewWorker.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewWorker.Rows[rowIndex];
            int index = Convert.ToInt32(selectedRow.Cells[0].Value);
            WorkerEdit we = new WorkerEdit(MainForm.DatabaseHRDataConnection, index);
            we.ShowDialog();
        }

    }
}
