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

    public partial class SalaryForm : Form
    {

        DatabaseHRDataContext DatabaseHRSalary = new DatabaseHRDataContext();
        DatabaseHRDataContext DatabaseHRConctract = new DatabaseHRDataContext();

        public SalaryForm()
        {
            InitializeComponent();
           // LoadSalary();

        }

        public void LoadSalary()
        {


            var stu = (from DatabaseHRSalary in DatabaseHRSalary.TypeContracts join DatabaseHRConctract in DatabaseHRConctract.Contract on DatabaseHRSalary.Id equals DatabaseHRConctract.Id

                       select new
                      {
                         DatabaseHRSalary.TypUmowy,
                         DatabaseHRSalary.Id,
                         DatabaseHRConctract.DataRozpoczęcia
                       });

            dataGridViewSalary.DataSource = stu.ToList();



        }

        public class TestLinqToSql
        {
            public int ReportId { get; set; }
            public string ReportName { get; set; }
            public string FormatName { get; set; }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadSalary();
        }
    }
}
