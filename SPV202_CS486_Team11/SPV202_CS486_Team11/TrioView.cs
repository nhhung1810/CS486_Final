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
    public partial class TrioView : Form
    {
        public TrioView()
        {
            InitializeComponent();
        }

        private void TrioView_Load(object sender, EventArgs e)
        {
            DataSet data = Misc.getData("Select STRING_AGG(s.name, ',') as singers, Songs.name as Song_name from Performance as p join singers as s on s.id = p.singerid join Songs on Songs.id = p.songid where p.songid in (select songid from performance as p group by p.songid having count(p.singerid) = 3) GROUP by p.songid, Songs.name");
            if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Cannot load data");
                return;
            }
            for(int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                trioPanel.Controls.Add(
                    new Trio(data.Tables[0].Rows[i][0].ToString(), data.Tables[0].Rows[i][1].ToString())
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
