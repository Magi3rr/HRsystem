using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR
{
    public partial class MainForm : Form
    {
        WorkersForm wf = new WorkersForm();
        ContractsForm cf = new ContractsForm();
        SalaryForm sf = new SalaryForm();
        PositionForm pf = new PositionForm();

        public static DatabaseHRDataContext DatabaseHRDataConnection = new DatabaseHRDataContext();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SlidePanel(Button btn)
        {
            slidePanel.Top = btn.Top;
            slidePanel.Height = btn.Height;
            slidePanel.Visible = btn.Enabled;
            //

        }
        private void BtnWorkers_Click(object sender, EventArgs e)
        {
            hide();
            SlidePanel(btnWorkers);
            wf.TopLevel = false;
            centerPanel.Controls.Add(wf);
            wf.Show();
        }

     
        

        private void BtnSalary_Click(object sender, EventArgs e)
        {
            hide();
            SlidePanel(btnSalary);
            sf.TopLevel = false;
            centerPanel.Controls.Add(sf);
            sf.Show();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            hide();
            SlidePanel(btnPosition);
            pf.TopLevel = false;
            centerPanel.Controls.Add(pf);
            pf.Show();




        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            hide();
            SlidePanel(btnContracts);
            cf.TopLevel = false;
            centerPanel.Controls.Add(cf);
            cf.Show();
        }

        private void hide()
        {
            wf.Hide();
            sf.Hide();
            pf.Hide();
            cf.Hide();

        }

        
    }
}
