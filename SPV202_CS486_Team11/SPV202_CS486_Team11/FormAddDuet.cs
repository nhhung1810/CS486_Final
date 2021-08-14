using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SPV202_CS486_Team11
{
    public partial class FormAddDuet : Form
    {
        string officialID = "";
        public FormAddDuet()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Misc.getConnectionString();

            SqlCommand cmd = new SqlCommand("addDuet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@reverse", SqlDbType.Int).Value = officialID;
            cmd.Parameters.AddWithValue("@official", SqlDbType.Int).Value = textID.Text;
            cmd.Parameters.AddWithValue("@songID", SqlDbType.Int).Value = textSongID.Text;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESS!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
