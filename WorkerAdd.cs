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
   
    public partial class WorkerAdd : Form
    {
        public WorkerAdd()
        {
            InitializeComponent();           
        }

        private void BtnCloseWr_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void BtnAddWorker_Click(object sender, EventArgs e)
        {
            Worker newWorker = new Worker();
            newWorker.Name = txtName.Text;
            newWorker.Surname = txtLastName.Text;
            newWorker.Genders = cbGender.SelectedItem as Genders;
            newWorker.dtBirth = dtBirth.Value;
            newWorker.Pesel = txtPESEL.Text;
            newWorker.Statuses = cbStatus.SelectedItem as Statuses;

            MainForm.DatabaseHRDataConnection.Worker.InsertOnSubmit(newWorker);
            MainForm.DatabaseHRDataConnection.SubmitChanges();
            var workersForm = Application.OpenForms.OfType<WorkersForm>().Single();
            workersForm.LoadWorkers();
            Close();
        }

        private void WorkerAdd_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = MainForm.DatabaseHRDataConnection.Genders;
            cbStatus.DataSource = MainForm.DatabaseHRDataConnection.Statuses;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       
    }
}
