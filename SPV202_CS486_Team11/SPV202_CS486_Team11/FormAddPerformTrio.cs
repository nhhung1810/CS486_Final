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
    public partial class FormAddPerformTrio : Form
    {
        string singerID = "";
        public FormAddPerformTrio(string ID)
        {
            InitializeComponent();
            singerID = ID;
        }

        private void FormAddPerformTrio_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Misc.getConnectionString();

            SqlCommand cmd = new SqlCommand("addPerformance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@singerID", SqlDbType.Int).Value = singerID;
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
