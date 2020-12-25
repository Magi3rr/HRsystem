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

        DatabaseHRDataContext DatabaseHRWorkers = new DatabaseHRDataContext();
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
            newWorker.Imie = txtName.Text;
            newWorker.Nazwisko = txtLastName.Text;
            //lbSex.DataSource = DatabaseHRWorkers.Genders;
            //lbSex.DisplayMember = "Płeć";
            //newWorker.IdPłeć = lbSex.DataBindings.Control;
            newWorker.DataUrodzenia = dtBirth.Value;
            newWorker.PESEL = txtPESEL.Text;
            //newWorker.IdStatus = 1;


            DatabaseHRWorkers.Worker.InsertOnSubmit(newWorker);
            DatabaseHRWorkers.SubmitChanges();

            Close();
        }

    }
}
