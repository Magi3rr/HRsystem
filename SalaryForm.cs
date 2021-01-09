using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

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
                for( int i =0; i < dataGridViewSalary.Columns.Count+1; i++)
                {
                    for (int j =0; j< dataGridViewSalary.Columns.Count + 1; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridViewSalary.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            //https://living-sun.com/pl/c/185903-issues-with-class-factory-for-component-with-clsid-00024500-0000-0000-c000-000000000046-c-ms-word-aspnet-35.html
        }

    }
}