using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace set2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Misc.getConnectionString();

            SqlCommand cmd = new SqlCommand("addSong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = textID.Text;
            cmd.Parameters.AddWithValue("@name", SqlDbType.Int).Value = textID.Text;
            cmd.Parameters.AddWithValue("@number", SqlDbType.Int).Value = textSongID.Text;
        }
    }
}
