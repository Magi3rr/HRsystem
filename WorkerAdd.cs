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

        private void btnCloseWr_Click(object sender, EventArgs e)
        {
            Close();
        }

       


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            Worker newWorker = new Worker();
            newWorker.Name = txtName.Text;
            newWorker.Surname = txtLastName.Text;
            newWorker.IdSex = 1;
            if (rbButtonFemale.Checked)
            {
                newWorker.IdSex = 2;
            }
            newWorker.dtBirth = dtBirth.Value;
            newWorker.Pesel = txtPESEL.Text;
            newWorker.IdStatus = 1; // aktywny

           
            MainForm.DatabaseHRDataConnection.Workers.InsertOnSubmit(newWorker);
            MainForm.DatabaseHRDataConnection.SubmitChanges();
            var workersForm = Application.OpenForms.OfType<WorkersForm>().Single();
            workersForm.LoadWorkers();
     

           Close();
        }

        private void WorkerAdd_Load(object sender, EventArgs e)
        {
            //lbStatus.DataSource=   //zaciąganie danych z bazy podczas wczytywania okna
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
