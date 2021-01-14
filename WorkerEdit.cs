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
            cbGender.SelectedItem = w.Genders;
            dtBirth.Value = w.dtBirth;
            txtPESEL.Text = w.Pesel;
            cbStatus.SelectedItem = w.Statuses;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditWorker_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtLastName.Text) && String.IsNullOrEmpty(txtPESEL.Text))
            {
                MessageBox.Show("Nie wypełniłeś wszystkich pól");
            }
            else
            {
                w.Name = txtName.Text;
                w.Surname = txtLastName.Text;
                w.Genders = cbGender.SelectedItem as Genders;
                w.dtBirth = dtBirth.Value;
                w.Pesel = txtPESEL.Text;
                w.Statuses = cbStatus.SelectedItem as Statuses;

                DatabaseHRWorkers.SubmitChanges();
                Close();
            }
            
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = MainForm.DatabaseHRDataConnection.Genders;
            cbStatus.DataSource = MainForm.DatabaseHRDataConnection.Statuses;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPESEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
