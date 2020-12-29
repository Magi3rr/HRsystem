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

            var emp = (from x in DatabaseHRWorkers.Workers select x).ToList();
            dataGridViewWorker.DataSource = emp;
        }

        public void LoadContracts()
        {

            var con = (from x in DatabaseHRWorkers.Contract select x).ToList();
            dataGridViewWorker.DataSource = con;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int rowIndex = dataGridViewWorker.CurrentCell.RowIndex;              
            DataGridViewRow selectedRow = dataGridViewWorker.Rows[rowIndex];
            int index = Convert.ToInt32(selectedRow.Cells[0].Value);
            test.Text = index.ToString();

            var query = from t in DatabaseHRWorkers.Workers where t.Id == index select t;

            foreach (var t in query)
            {
                DatabaseHRWorkers.Workers.DeleteOnSubmit(t);
            }
            
            DatabaseHRWorkers.SubmitChanges();  //nieobsługiwany wyjątek System.Data.Linq.ChangeConflictException

           

            LoadWorkers();
            MessageBox.Show("Rekord usunięty");
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            WorkerAdd Adw = new WorkerAdd(); 
            Adw.Show();
            LoadWorkers();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            //DatabaseHRDataContext cd = new DatabaseHRDataContext();
            var emp = (from x in DatabaseHRWorkers.Workers select x).ToList();
            dataGridViewWorker.DataSource = emp;
        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            

            int rowIndex = dataGridViewWorker.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewWorker.Rows[rowIndex];
            int index = Convert.ToInt32(selectedRow.Cells[0].Value);
            WorkerEdit we = new WorkerEdit(DatabaseHRWorkers, index);
            //we.txtName.Text = dataGridViewWorker.CurrentRow.Cells[1].Value.ToString();
            //we.txtLastName.Text = dataGridViewWorker.CurrentRow.Cells[2].Value.ToString();
            
            we.ShowDialog();



            /*
            int rowIndex = dataGridViewWorker.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewWorker.Rows[rowIndex];
            int index = Convert.ToInt32(selectedRow.Cells[0].Value);
            Worker wrk = DatabaseHRWorkers.Worker.FirstOrDefault(wrk1 => wrk1.Id.Equals(index));
            //test.Text = index.ToString();
            

            wrk.Imie = "zzz";
            wrk.Nazwisko = "zzzzz";

            DatabaseHRWorkers.SubmitChanges();

            var SelectQuery =
                from a in DatabaseHRWorkers.GetTable<Worker>()
                select a;

            dataGridViewWorker.DataSource = SelectQuery;
            */

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gendersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contractBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
