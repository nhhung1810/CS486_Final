﻿using System;
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
            DataSet data = Misc.getData("");
            //Invalid account
            if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Your member key is not valid");
                return;
            }
            if (true) GoToOfficial();
            else GoToReverse();
        }

        private void GoToOfficial()
        {

        }

        private void GoToReverse()
        {

        }
    }
}
