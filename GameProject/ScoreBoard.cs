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
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void switchFrame()
        {
            ScoreBoard s = new ScoreBoard();
            this.Close();
            parent.Show();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
