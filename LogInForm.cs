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
            
            /* var user = (from w in Dblog.LogIn
                        where s.Uzytkownik == textBox1.Text
                        select w).First(); 
            if (user.pass == textBox2.Text)
            {
                MainForm log = new MainForm();
                log.Show();
            }
            else
            {
                MessageBox.Show("Bledne dane logowania");

            }    */
                Open();
        }

        public void Open()
        {
            using (MainForm mf = new MainForm())
            {
                mf.ShowDialog();
                this.Close();
            }
        }
    }
}
