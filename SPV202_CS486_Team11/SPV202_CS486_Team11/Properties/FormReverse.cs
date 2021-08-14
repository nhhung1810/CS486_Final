using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV202_CS486_Team11.Properties
{
    public partial class FormReverse : Form
    {
        string id = "";
        public FormReverse(string ID)
        {
            InitializeComponent();
            id = ID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddPerformTrio form = new FormAddPerformTrio(id);
        }
    }
}
