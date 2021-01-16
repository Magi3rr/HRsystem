using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace HR
{

    public partial class SalaryForm : Form
    {



        public SalaryForm()
        {
            InitializeComponent();
            LoadSalary();

        }

        public void LoadSalary()
        {


            var stu = (from DatabaseHRSalary in MainForm.DatabaseHRDataConnection.TypeContracts
                       join DatabaseHRConctract in MainForm.DatabaseHRDataConnection.Contract on
                       DatabaseHRSalary.Id equals DatabaseHRConctract.IdContractType
                       join
                       DatabaseWorkers in MainForm.DatabaseHRDataConnection.Worker on
                       DatabaseHRConctract.IdWorker equals DatabaseWorkers.Id

                       select new
                       {
                           DatabaseHRSalary.Id,
                           DatabaseWorkers.Name,
                           DatabaseWorkers.Surname,
                           DatabaseHRSalary.typeContract,
                           DatabaseHRConctract.Salary,
                           DatabaseHRConctract.dtStartContract,
                           DatabaseHRConctract.dtEndContract,
                           DatabaseHRSalary.Contract

                       });

            dataGridViewSalary.DataSource = stu.ToList();
            dataGridViewSalary.Columns["dtStartContract"].HeaderText = "Data podpisania ";
            dataGridViewSalary.Columns["dtEndContract"].HeaderText = "Data wygaśnięcia umowy ";
            dataGridViewSalary.Columns["Salary"].HeaderText = "Wynagrodzenie ";
            dataGridViewSalary.Columns["TypeContract"].HeaderText = "Rodzaj umowy ";
            dataGridViewSalary.Columns["Name"].HeaderText = "Imie  ";
            dataGridViewSalary.Columns["Surname"].HeaderText = "Nazwisko  ";
            dataGridViewSalary.Columns["Id"].Visible = false;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           

            if (dataGridViewSalary.Rows.Count >0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for( int i =0; i < dataGridViewSalary.Rows.Count+1; i++)
                {
                    for (int j =0; j< dataGridViewSalary.Columns.Count + 1; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridViewSalary.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
           
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {

            TextWriter writer = new StreamWriter(@"C:/ExportHR/ExportWynagrodzenia.txt");
            for (int i = 0; i < dataGridViewSalary.Rows.Count ; i++)
            {
                for (int j = 0; j < dataGridViewSalary.Columns.Count -1 ; j++)
                {
                    writer.Write("\t"+dataGridViewSalary.Rows[i].Cells[j].Value.ToString()+ "\t"+ "|");
             
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------");   
            }
            writer.Close();
            MessageBox.Show("Eksport udany, pliki znajdują się na dysku C, sprawdź folder o nazwie ExportHR");


        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            LoadSalary();
        }
    }
}