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
    public partial class WorkerEdit : Form
    {
        DatabaseHRDataContext DatabaseHRWorkers;
        Worker w;
        public WorkerEdit(DatabaseHRDataContext DatabaseHRWorkers, int id)
        {
            InitializeComponent();

            this.DatabaseHRWorkers = DatabaseHRWorkers;
            w = DatabaseHRWorkers.Worker.Single(x => x.Id == id);
            txtName.Text = w.Imie;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            w.Imie = txtName.Text;
            DatabaseHRWorkers.SubmitChanges();

        }
    }
}
