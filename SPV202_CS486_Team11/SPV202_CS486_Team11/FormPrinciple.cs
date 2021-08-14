using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV202_CS486_Team11
{
    public partial class FormPrinciple : Form
    {
        string id = "";
        public FormPrinciple(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void FormPrinciple_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddPerformTrio form = new FormAddPerformTrio(id);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddInter_Prin form = new FormAddInter_Prin(id);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddDuet form = new FormAddDuet(id);
            form.ShowDialog();
        }
    }
}
