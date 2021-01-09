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
            w = DatabaseHRWorkers.Worker.Single(x => x.Id == id);

            txtName.Text = w.Name;
            txtLastName.Text = w.Surname;
            //cbGender.SelectedIndex = w.IdSex-1;
            cbGender.SelectedItem = w.Genders;
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
            w.Genders = cbGender.SelectedItem as Genders;
            //tbtest.Text = cbGender.ToString();
            //tbtest.Text = cbGender.SelectedIndex.ToString();
            
           



            DatabaseHRWorkers.SubmitChanges();
            //Close();

        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = MainForm.DatabaseHRDataConnection.Genders;
            //cbStatus.DataSource = MainForm.DatabaseHRDataConnection.Statuses;
        }
    }
}
