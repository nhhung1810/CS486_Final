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
    public partial class FormRuleMember : Form
    {
        public FormRuleMember()
        {
            InitializeComponent();
        }

        FlowLayoutPanel flpTmp;
        private void FormRuleMember_Load(object sender, EventArgs e)
        {
            flpRule.FlowDirection = FlowDirection.TopDown;
            flpRule.WrapContents = false;
            Button rule = new Button { Text = "Rule" };
            rule.Location = new Point(0, 0);
            rule.Font = new Font("Georgie", 12, FontStyle.Bold);
            rule.Height = 40;
            rule.Width = 70;
            flpRule.Controls.Add(rule);
            
            Label lbl = new Label();
            lbl.Text = "The six Principal members each choose an Understudy member to sing a duet with. Both members need a Principal recommendation to become Principal members. In the event that more than three groups are chosen as Principals, one of the Principal groups is challenged for their spot in a solo battle.";
            lbl.Location = new Point(0, 0);
            lbl.Height = 600;
            lbl.Width = 200;
            flpRule.Controls.Add(lbl);
            //initRule();

            DataSet data = Misc.getData("");//select Official
            if (data != null && data.Tables.Count > 0)
                dgvOfficial.DataSource = data.Tables[0];
            data = Misc.getData("");//Select NonOfficial
            if (data != null && data.Tables.Count > 0)
                dgvNonOfficial.DataSource = data.Tables[0];
        }

        public void initRule()
        {

            Button rule = new Button { Text = "Rule" };
            rule.Location = new Point(0, 0);
            rule.Font = new Font("Georgie", 12, FontStyle.Bold);
            rule.Height = 40;
            rule.Width = 70;
            flpRule.Controls.Add(rule);
            flpTmp = new FlowLayoutPanel();
            flpTmp.AutoScroll = true;
            flpTmp.WrapContents = false;
            flpTmp.FlowDirection = FlowDirection.RightToLeft;

            int width = 0;
            Button btn = new Button { Text = "section03" };
            btn.Location = new Point(0, 0);
            btn.Name = "section03";
            btn.Click += new EventHandler(section_click);
            btn.Width = btn.PreferredSize.Width;
            btn.Height = btn.PreferredSize.Height;
            width += btn.Width + 20;
            flpTmp.Controls.Add(btn);

            btn = new Button { Text = "section04" };
            btn.Location = new Point(width, 0);
            btn.Name = "section04";
            btn.Click += new EventHandler(section_click);
            btn.Width = btn.PreferredSize.Width;
            btn.Height = btn.PreferredSize.Height;
            width += btn.Width + 20;
            flpTmp.Controls.Add(btn);

            btn = new Button { Text = "section05" };
            btn.Location = new Point(width, 0);
            btn.Name = "section05";
            btn.Click += new EventHandler(section_click);
            btn.Width = btn.PreferredSize.Width;
            btn.Height = btn.PreferredSize.Height;
            width += btn.Width + 20;
            flpTmp.Controls.Add(btn);

            flpTmp.Width = width;
            flpTmp.Height = btn.Height + 20;

            flpRule.Controls.Add(flpTmp);
        }
        public void section_click(object sender, EventArgs s)
        {
            Button btn = sender as Button;
            initLabelRule(btn.Name.ToString());
        }
        public void initLabelRule(string rule)
        {
            Label lbl = new Label();
            if (rule == "section03")
                lbl.Text = "aaa";
            else if (rule == "section04")
                lbl.Text = "bbb";
            else if (rule == "section05")
                lbl.Text = "ccc";
            lbl.Location = new Point(0, 0);
            flpRule.Controls.Add(lbl);//about 
        }
        /*public Button addRuleButton(Control control, string text, int x, int y)
        {
            control = new Button()
        }*/
    }
}
