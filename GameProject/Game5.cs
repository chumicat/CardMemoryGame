using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;



namespace GameProject
{
    public partial class Game5 : Form
    {
        Button[,] buttons = new Button[DEFINE.COL_SIZE, DEFINE.ROW_SIZE];
        int[,] plane = new int[DEFINE.COL_SIZE, DEFINE.ROW_SIZE];
        Random rnd = new Random();
        int t_conumter = 0;
        int remaining_card; // unit is pair
        SoundPlayer sound_true = new SoundPlayer(DEFINE.S_TRUE);
        SoundPlayer sound_false = new SoundPlayer(DEFINE.S_FALSE);
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public Game5()
        {
            InitializeComponent();
        }

        private void Game5_Load(object sender, EventArgs e)
        {
            // background music setting
            wmp.URL = "background.mp3";

            // genetrate button
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
            {
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Location = new Point(x * (this.Width - DEFINE.WIDTH_GAP)/DEFINE.COL_SIZE, y * (this.Height - DEFINE.HEIGHT_GAP)/DEFINE.ROW_SIZE);
                    this.Controls.Add(buttons[x, y]);
                    buttons[x, y].Size = new Size((this.Width - DEFINE.WIDTH_GAP) / DEFINE.COL_SIZE, (this.Height - DEFINE.HEIGHT_GAP) / DEFINE.ROW_SIZE);
                    buttons[x, y].Click += new EventHandler(this.Button_Click);
                    buttons[x, y].Text = Convert.ToString(index(x, y));
                    buttons[x, y].Name = Convert.ToString(index(x, y));
                    plane[x, y] = index(x, y)%(DEFINE.COL_SIZE* DEFINE.ROW_SIZE/2);
                    //Text = Convert.ToString(buttons[x, y].Size.ToString());
                    
                }
            }

            // shuffle the card
            shuffle();

            // initial the counter
            remaining_card = DEFINE.COL_SIZE * DEFINE.ROW_SIZE / 2;

            // initial the timer
            t_conumter = 0;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            return;
        }

        private int index(int x, int y)
        {
            return y * DEFINE.COL_SIZE + x;
        }

        private void shuffle() {
            // genetrate number to each card
            for (int n = 0; n < DEFINE.SHUFFLE_TIMES; n++)
                Tools.Swap<int>(ref plane[rnd.Next() % DEFINE.COL_SIZE, rnd.Next() % DEFINE.ROW_SIZE],
                                ref plane[rnd.Next() % DEFINE.COL_SIZE, rnd.Next() % DEFINE.ROW_SIZE]);

            // tmp part to make num print on screem
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                    buttons[x, y].Text = Convert.ToString(plane[x, y]);

            return;
        }

        bool se = false;    // selected boolean
        Button target;      // selected button reference
        private void Button_Click(Object sender, EventArgs e)
        {
            Button this_sender = (Button)sender;

            if (!se) {
                // first time situation
                Text = "";
                target = this_sender;
                se = true;
            }else if (this_sender.Equals(target)){
                // select same situation (do nothing)
            }else if (Convert.ToInt32(target.Text) == Convert.ToInt32(this_sender.Text)){
                // correct situation
                target.Hide();
                this_sender.Hide();
                remaining_card--;
                sound_true.Play();
                se = false;
                // end of game
                if (remaining_card == 0) {
                    this.Hide();
                    Parent.Show();
                }
            }else{
                // false situation
                sound_false.Play();
                se = false;
            }
            return;
        }

        private void reset() {
            // show all of the buttons
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                    buttons[x, y].Show();

            // shuffle the cards position
            shuffle();

            // initial the counter
            remaining_card = DEFINE.COL_SIZE * DEFINE.ROW_SIZE / 2;

            // reenable timer.
            t_conumter = 0;
            timer1.Enabled = true;
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //t_conumter++;
            //Text = Convert.ToString(t_conumter);
        }

        private void Game5_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.close();
        }
    }

    static class DEFINE
    {
        public const int ROW_SIZE = 4;
        public const int COL_SIZE = 8;
        public const int WIDTH_GAP = 16;
        public const int HEIGHT_GAP = 38;
        public const int SHUFFLE_TIMES = 200;
        public const String S_TRUE = "../../Resources/sound/true.wav";
        public const String S_FALSE = "../../Resources/sound/false.wav";
        public const String M_BACKGROUND = "../../Resources/music/background.mp3";
    }

    static class Tools
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
