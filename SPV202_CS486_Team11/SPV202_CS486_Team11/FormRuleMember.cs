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
            this.ControlBox = true;
            flpRule.FlowDirection = FlowDirection.TopDown;
            flpRule.WrapContents = false;
            flpRule.AutoScroll = true;
            Button rule = new Button { Text = "Rule" };
            rule.Location = new Point(0, 0);
            rule.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            rule.BackColor = Color.Green;
            rule.ForeColor = Color.White;
            rule.FlatStyle = FlatStyle.Flat;
            rule.Height = 40;
            rule.Width = 70;
            flpRule.Controls.Add(rule);
            
            Label lbl = new Label();
            lbl.Text = "*From episodes 1-7, the six best performances (solo, duets, or trios) " +
                "are chosen after being judged by the three show producers, and are given the " +
                "Principal recommendation.\n*Six other performances are chosen as Understudy " +
                "recommendations, and attempt to defeat the Principal performances. \n*The ending " +
                "Principal performances go on to be the Principal performances of the next " +
                "week. \n*Starting in episode 8, the members divide into six groups of six members, " +
                "led by members who have been Principal performers the most. \n*The final round culminates " +
                "in six winners, that were able to go on to perform on Singer 2019, as a Challenger Singer. ";
            lbl.Font = new Font("Times New Roman", 12);
            lbl.Location = new Point(0, 0);
            lbl.Height = 200;
            lbl.Width = this.Size.Width;
            flpRule.Controls.Add(lbl);
            flpRule.Height = rule.Height + lbl.Height - 20;
            flpRule.Width = this.Size.Width;
            //initRule();
            DataSet data = Misc.getData("select Singers.id, Singers.name from Singers where Singers.isOfficial = 1");//select Official
            if (data != null && data.Tables.Count > 0)
                dgvOfficial.DataSource = data.Tables[0];
            data = Misc.getData("select Singers.id, Singers.name from Singers where Singers.isOfficial = 0");//Select NonOfficial
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
        
    }
}
