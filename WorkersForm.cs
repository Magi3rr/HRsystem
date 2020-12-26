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

            var emp = (from x in DatabaseHRWorkers.Worker select x).ToList();
            dataGridViewWorker.DataSource = emp;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewWorker.SelectedRows)
            {
                
                int rowId = Convert.ToInt32(row.Cells[0].Value);

                
                if (rowId > 0)
                {
                  
                    

                    
                    dataGridViewWorker.Rows.RemoveAt(row.Index);
                }
            }


            LoadWorkers();
            MessageBox.Show("Rekord usunięty");
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            LoadWorkers();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            DatabaseHRDataContext cd = new DatabaseHRDataContext();
            var emp = (from x in DatabaseHRWorkers.Worker select x).ToList();
            dataGridViewWorker.DataSource = emp;
        }
       

    }
}
