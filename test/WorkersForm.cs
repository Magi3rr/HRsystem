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

       private void LoadWorkers()
        {
            listBoxWorkers.Items.Clear();
            foreach (Worker w in DatabaseHRWorkers.Worker)
            {
                listBoxWorkers.Items.Add(w);

            }  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
    }
}
