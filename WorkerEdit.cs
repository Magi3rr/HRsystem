using OpenXmlPowerTools;
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
            w = DatabaseHRWorkers.Worker.Single(x => x.IdSex == id);
            //w = DatabaseHRWorkers.Worker.Single(x => x.IdSex == IdSex);

            txtName.Text = w.Name;
            txtLastName.Text = w.Surname;
            cbGender.SelectedIndex = w.IdSex-1;
            dtBirth.Value = w.dtBirth;


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditWorker_Click(object sender, EventArgs e)
        {
            w.Name = txtName.Text;
            w.Surname = txtLastName.Text;
            //var a = Convert.ToInt32(cbGender.SelectedIndex) + 1;
            w.IdSex = Convert.ToInt32(cbGender.SelectedIndex) + 1;
            
            DatabaseHRWorkers.SubmitChanges();
            //Close();

        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            //cbGender.DataSource = MainForm.DatabaseHRDataConnection.Genders;
            //cbStatus.DataSource = MainForm.DatabaseHRDataConnection.Statuses;
        }
    }
}
