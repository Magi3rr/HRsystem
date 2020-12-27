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
        DatabaseHRDataContext DatabaseHRPosition = new DatabaseHRDataContext();
        public PositionForm()
        {
            InitializeComponent();
            LoadPosition();
        }

        public void LoadPosition()
        {

            var sal = (from x in DatabaseHRPosition.Positions select x).ToList();
            dataGridViewPositions.DataSource = sal;
        }
    }
}
