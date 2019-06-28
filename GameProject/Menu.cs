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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void resetSkin() {
            this.r_CardType.SelectedItem = null;
        }

        private void b_game5_Click(object sender, EventArgs e)
        {
            if (this.r_CardType.SelectedItem == null)
                return;
            else if (this.r_CardType.SelectedItem.Equals(this.r_CardType.Items[0]))
                Game5.C_FOLDER = "T00";
            else if (this.r_CardType.SelectedItem.Equals(this.r_CardType.Items[1]))
                Game5.C_FOLDER = "T01";
            else
                Game5.C_FOLDER = "T00";
            Game5 t = new Game5(this);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void l_playerNumber_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
