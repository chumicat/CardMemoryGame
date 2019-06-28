using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class ScoreBoard : Form
    {
        Game5 parent;
        public ScoreBoard(Game5 p)
        {
            InitializeComponent();
            parent = p;
            int t_scores = parent.t_counter > DEFINE.MAX_TIME ? 0 : (DEFINE.MAX_TIME - parent.t_counter) * DEFINE.TIME_SCALE;
            int s_scores = parent.s_counter > DEFINE.MAX_STEP ? 0 : (DEFINE.MAX_STEP - parent.s_counter) * DEFINE.STEP_SCALES;
            this.r_Time.Text = Convert.ToString(parent.t_counter);
            this.r_Step.Text = Convert.ToString(parent.s_counter);
            this.r_Scores.Text = Convert.ToString((t_scores + s_scores));
            this.Show();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {

        }

        private void b_Restart_Click(object sender, EventArgs e)
        {
            parent.reset();
            this.Close();
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            parent.parent.Show();
            parent.Close();
            this.Close();
        }
    }
}
