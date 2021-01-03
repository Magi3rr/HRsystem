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
            txtName.Text = w.Name;
            txtLastName.Text = w.Surname;

            //wyświetlanie z comboboxa
            //dtBirth.Format = w.dtBirth;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            w.Name = txtName.Text;
            w.Surname = txtLastName.Text;
            DatabaseHRWorkers.SubmitChanges();
            Close();

        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = MainForm.DatabaseHRDataConnection.Genders;
            cbStatus.DataSource = MainForm.DatabaseHRDataConnection.Statuses;
        }
    }
}
