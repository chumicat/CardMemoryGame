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
            else{
                for (int n = 0; n < r_CardType.Items.Count; n++) {
                    if (this.r_CardType.SelectedItem.Equals(this.r_CardType.Items[n])) {
                        if(n<10)
                            Game5.C_FOLDER = "T0" + n.ToString();
                        else
                            Game5.C_FOLDER = "T" + n.ToString();
                    }
                }

            }
            Game5 t = new Game5(this);
            t.autoFlipBack = this.r_AutoFlip.Checked;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
