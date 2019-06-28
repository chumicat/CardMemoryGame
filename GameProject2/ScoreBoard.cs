using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject2
{
    public partial class ScoreBoard : Form
    {
        Game6 parent;
        public ScoreBoard()
        {
            InitializeComponent();
            r_Fox.Text   = state(parent.animalDie[0]) + level(parent.animalLEVEL[0]);
            r_Bear.Text  = state(parent.animalDie[1]) + level(parent.animalLEVEL[1]);
            r_Eagle.Text = state(parent.animalDie[2]) + level(parent.animalLEVEL[2]);
            r_Snake.Text = state(parent.animalDie[3]) + level(parent.animalLEVEL[3]);
            this.Show();
        }

        private String state(bool isDead) {
            if (isDead)
                return "Dead,  ";
            else
                return "Alive, ";
        }

        private String level(int animalLEVEL) {
            if (animalLEVEL < 3)
                return "Level " + animalLEVEL.ToString();
            else
                return "Level Max";
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
