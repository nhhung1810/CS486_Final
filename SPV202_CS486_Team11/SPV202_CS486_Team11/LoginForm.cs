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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DataSet data = Misc.getData("select isOfficial from Singer where Singer.id = " + id.Text);
            //Invalid account
            if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Your member key is not valid");
                return;
            }
            if (data.Tables[0].Rows[0].ToString() == "1") GoToOfficial(id.Text);
            else GoToReverse(id.Text);
        }

        private void GoToOfficial(string id)
        {

        }

        private void GoToReverse(string id)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
