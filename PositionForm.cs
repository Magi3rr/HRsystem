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
    public partial class PositionForm : Form
    {
       
        public PositionForm()
        {
            InitializeComponent();
            LoadPosition();
        }

        public void LoadPosition()
        {

            var sal = (from DatabasePositions in MainForm.DatabaseHRDataConnection.Positions
                       join
                       DatabaseContracts in MainForm.DatabaseHRDataConnection.Contract on
                       DatabasePositions.Id equals DatabaseContracts.IdPosition
                       join
                       DatabaseWorkers in MainForm.DatabaseHRDataConnection.Worker on
                       DatabaseContracts.IdWorker equals DatabaseWorkers.Id
                       select new
                       {
                           DatabaseWorkers.Name,
                           DatabaseWorkers.Surname,
                           DatabasePositions.WorkerPosition,
                           DatabaseContracts.dtStartContract,
                           DatabaseContracts.TypeContracts

                       }) ;
            dataGridViewPositions.DataSource = sal.ToList();
            dataGridViewPositions.Columns["Name"].HeaderText = "Imie ";
            dataGridViewPositions.Columns["Surname"].HeaderText = "Nazwisko ";
            dataGridViewPositions.Columns["WorkerPosition"].HeaderText = "Stanowisko ";
            dataGridViewPositions.Columns["TypeContracts"].HeaderText = "Rodzaj umowy ";
            dataGridViewPositions.Columns["dtStartContract"].HeaderText = "Data rozpoczęcia umowy ";


        }



    }
}
