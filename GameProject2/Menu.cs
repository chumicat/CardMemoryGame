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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void b_Game6_Click(object sender, EventArgs e)
        {
            Game6 t = new Game6(this);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
