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
    public partial class AddWorker : Form
    {

        DatabaseHRDataContext DatabaseHRWorkers = new DatabaseHRDataContext();
        public AddWorker()
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
            newWorker.Imie = txtName.Text;
            newWorker.Nazwisko = txtLastName.Text;

            newWorker.Płeć = lbSex.ValueMember;
            newWorker.Data_urodzenia = dtBirth.Value;
            newWorker.Status = txtStatus.Text;
            newWorker.Wynagrodzenie = updSalary.Value;
            //DatabaseHRDataContext.SubmitChanges();



            // DatabaseHRWorkers.InsertOnSubmit(newWorker);


        }
    }
}
