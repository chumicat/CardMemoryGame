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
        // plane , tool and reference
        private Button[,] buttons = new Button[DEFINE.COL_SIZE, DEFINE.ROW_SIZE];
        private int[] plane = new int[DEFINE.COL_SIZE * DEFINE.ROW_SIZE];
        private Random rnd = new Random();
        public Menu parent;

        // counter to store something
        private int remaining_card; // unit is pair
        public int t_counter = 0;   // time passing counter
        public int s_counter = 0;   // step using counter (pair for 1 plus)

        // music and effects
        private SoundPlayer sound_true = new SoundPlayer(DEFINE.S_TRUE);
        private SoundPlayer sound_false = new SoundPlayer(DEFINE.S_FALSE);
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        // constructor
        public Game5(Menu p)
        {
            parent = p;
            InitializeComponent();
            parent.Hide();
            this.Show();
            return;
        }

        /// <summary>
        /// Call this when finish the puzzle.
        /// It will show the scoresboard and user should selected what to do next.
        /// </summary>
        private void switchFrame() {
            ScoreBoard s = new ScoreBoard(this);
            return;
        }

        /// <summary>
        /// Initial everything, 
        /// including buttons genetrating, music setting, name binding and time setting.
        /// </summary>
        private void Game5_Load(object sender, EventArgs e)
        {
            // background music setting
            wmp.URL = DEFINE.M_BACKGROUND;

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
                    //buttons[x, y].Text = Convert.ToString(index(x, y));
                    buttons[x, y].Name = Convert.ToString(index(x, y));
                    plane[index(x, y)] = index(x, y)%(DEFINE.COL_SIZE* DEFINE.ROW_SIZE/2);
                }
            }

            // initial the timer
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // initial normal setting
            reset();
            return;
        }

        /// <summary>
        /// Enter your row and column number and get the index.
        /// Used to get each button's value,
        /// because it would be easier than using two-dimensional array to check value.
        /// </summary>
        /// <param name="x">column number</param>
        /// <param name="y">row number</param>
        /// <returns>index</returns>
        private int index(int x, int y)
        {
            return y * DEFINE.COL_SIZE + x;
        }

        /// <summary>
        /// Shuffle the cards.
        /// You can set "how many times you want to shuffle" in DEFINE class
        /// </summary>
        private void shuffle() {
            // genetrate number to each card
            for (int n = 0; n < DEFINE.SHUFFLE_TIMES; n++)
                Tools.Swap<int>(ref plane[rnd.Next() % (DEFINE.COL_SIZE * DEFINE.ROW_SIZE)],
                                ref plane[rnd.Next() % (DEFINE.COL_SIZE * DEFINE.ROW_SIZE)]);

            // tmp part to make num print on screem
            //for (int y = 0; y < DEFINE.ROW_SIZE; y++)
            //    for (int x = 0; x < DEFINE.COL_SIZE; x++)
            //        buttons[x, y].Text = Convert.ToString(plane[index(x, y)]);

            return;
        }
        
        private void enable(bool enable) {
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++)
                    buttons[x, y].Enabled = enable;
            return;
        }

        bool se = false;    // selected boolean
        Button target;      // selected button reference
        /// <summary>
        /// Each button which be genetrated by the program will be binded to this function.
        /// It will handle each situation and change pictureson each cards.
        /// </summary>
        private void Button_Click(Object sender, EventArgs e)
        {
            Button this_sender = (Button)sender;

            if (!se) {
                // first time situation
                Text = "";
                target = this_sender;
                s_counter++;
                this_sender.Image = Image.FromFile(cardPhotoAddress(plane[Convert.ToInt32(this_sender.Name)]));
                se = true;
            }else if (this_sender.Equals(target)){
                // select same situation (do nothing)
            }else if (plane[Convert.ToInt32(target.Name)] == plane[Convert.ToInt32(this_sender.Name)]){
                // correct situation
                target.Hide();
                this_sender.Hide();
                remaining_card--;
                sound_true.Play();
                se = false;
                // end of game
                if (remaining_card == 0) {
                    switchFrame();
                }
            }else{
                // false situation
                sound_false.Play();
                this_sender.Image = Image.FromFile(cardPhotoAddress(plane[Convert.ToInt32(this_sender.Name)]));
                Task.WaitAll(Task.Delay(DEFINE.DELAY_TIME));
                target.Image = Image.FromFile(DEFINE.C_BACK);
                this_sender.Image = Image.FromFile(DEFINE.C_BACK);
                // should clear mouse event queue here, but I didn't nkow how
                se = false;
            }
            return;
        }

        private String cardPhotoAddress(int num) {

            if (num < 10 && num >= 0)
                return DEFINE.C_PRE + "0" + Convert.ToString(num) + DEFINE.C_POST;
            else if (num >= 10 && num < 16)
                return DEFINE.C_PRE + Convert.ToString(num) + DEFINE.C_POST;
            else
                return DEFINE.C_BACK;   // error
        }

        /// <summary>
        /// You can reset game by using this function, 
        /// like shuffle the cards again, initial the con\unter and timer.
        /// </summary>
        public void reset() {
            // show all of the buttons
            for (int y = 0; y < DEFINE.ROW_SIZE; y++)
                for (int x = 0; x < DEFINE.COL_SIZE; x++) {
                    buttons[x, y].Show();
                    buttons[x, y].Image = Image.FromFile(DEFINE.C_BACK);
                }

            // shuffle the cards position
            shuffle();

            // initial the counter
            remaining_card = DEFINE.COL_SIZE * DEFINE.ROW_SIZE / 2;
            s_counter = 0;

            // reenable timer.
            t_counter = 0;
            timer1.Enabled = true;
            return;
        }

        /// <summary>
        /// Timer function.
        /// p.s. timer will getting fired twice.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            t_counter++;
            Text = Convert.ToString(t_counter);
        }

        /// <summary>
        /// no matter why you close the form,
        /// we should show the parent form,
        /// or it would be a bad news.
        /// </summary>
        private void Game5_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.close();
            parent.Show();
        }
    }

    static class DEFINE
    {
        public const int ROW_SIZE = 4;
        public const int COL_SIZE = 8;
        public const int WIDTH_GAP = 16;
        public const int HEIGHT_GAP = 38;
        public const int SHUFFLE_TIMES = 200;
        public const int DELAY_TIME = 1200;
        public const String S_TRUE = "../../Resources/sound/true.wav";
        public const String S_FALSE = "../../Resources/sound/false.wav";
        public const String M_BACKGROUND = "background.mp3";
        public const String C_BACK = "../../Resources/game5_image/CB.png";
        public const String C_PRE = "../../Resources/game5_image/C";
        public const String C_POST = ".png";
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

        public static bool returnTime()
        {
            return false;
        }
    }
}
