﻿using System;
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
    public partial class LogInForm : Form
    {
        DatabaseHRDataContext Dblog = new DatabaseHRDataContext();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void BtnCloseLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(textBox1.Text, textBox2.Text))
            {
                Open();
            }
            else
                MessageBox.Show("Niepoprawne dane logowania", "Ostrzeżenie");

        }

        public void Open()
        {
            using (MainForm mf = new MainForm())
            {
                mf.ShowDialog();
                this.Close();
            }
        }

        private bool IsvalidUser(string userName, string password)
        {
            var q = from p in Dblog.logintbs where p.name == userName && p.passw == password select p;
       

            if (q.Any())

            {

                return true;

            }

            else

            {

                return false;

            }
        }

    }

}
