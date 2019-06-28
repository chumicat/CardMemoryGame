using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GameProject2
{
    enum ANIMAL_KIND { FOX, BEAR, EAGLE, SNAKE}
    enum FOOD_KIND { FISH, CHICKEN, MOUSE, DEER, ELEPHANT}
    
    public partial class Game6 : Form
    {
        public Menu parent;
        private QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[] animalHUNGER
            = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[DEFINE.ANIMAL_NUM];
        private QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[] animalLOVE
            = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[DEFINE.ANIMAL_NUM];
        private QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[] foodCT
            = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx[DEFINE.FOOD_NUM];
        public int[] animalLEVEL = new int[DEFINE.ANIMAL_NUM];
        private int[] AHcounter = new int[DEFINE.ANIMAL_NUM];
        private int[] ALcounter = new int[DEFINE.ANIMAL_NUM];
        private int[] FCcounter = new int[DEFINE.FOOD_NUM];
        private Button[] b_animal = new Button[DEFINE.ANIMAL_NUM];
        private Button[] b_food = new Button[DEFINE.FOOD_NUM];
        public bool[] animalDie = new bool[DEFINE.ANIMAL_NUM];
        private int holdFood = -1;


        public Game6(Menu p)
        {
            // setting
            InitializeComponent();
            parent = p;
            p.Hide();
            this.Show();

            // binding process bar
            animalHUNGER[0] = animalHUNGER_00;
            animalHUNGER[1] = animalHUNGER_01;
            animalHUNGER[2] = animalHUNGER_02;
            animalHUNGER[3] = animalHUNGER_03;
            animalLOVE[0] = animalLOVE_00;
            animalLOVE[1] = animalLOVE_01;
            animalLOVE[2] = animalLOVE_02;
            animalLOVE[3] = animalLOVE_03;
            foodCT[0] = foodCT_00;
            foodCT[1] = foodCT_01;
            foodCT[2] = foodCT_02;
            foodCT[3] = foodCT_03;
            foodCT[4] = foodCT_04;

            // binding button
            b_animal[0] = b_animal_00;
            b_animal[1] = b_animal_01;
            b_animal[2] = b_animal_02;
            b_animal[3] = b_animal_03;
            b_food[0] = b_food_00;
            b_food[1] = b_food_01;
            b_food[2] = b_food_02;
            b_food[3] = b_food_03;
            b_food[4] = b_food_04;

            // binding buttons to function
            //for (int n = 0; n < DEFINE.ANIMAL_NUM; n++)
            //    b_animal[n].MouseDown += new MouseEventHandler(bAnimal_Click);
            //for (int n = 0; n < DEFINE.FOOD_NUM; n++)
            //    b_food[n].MouseDown += new MouseEventHandler(bFood_Click);
            for (int n = 0; n < DEFINE.ANIMAL_NUM; n++)
                b_animal[n].MouseMove += new MouseEventHandler(bAnimal_Click);
            for (int n = 0; n < DEFINE.FOOD_NUM; n++)
                b_food[n].MouseMove += new MouseEventHandler(bFood_Click);

            // reset each element
            reset();

            // set level
            DEFINE.setPlayLevel(2);

            // initial the timer
            timer1.Interval = DEFINE.TIME_INTERVAL;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        public void reset() {
            // animal (reset counter and process bar and relife the animals)
            for (int n = 0; n < DEFINE.ANIMAL_NUM; n++) {
                AHcounter[n] = 0;
                ALcounter[n] = 0;
                animalHUNGER[n].Value = 70;
                animalLOVE[n].Value = 0;
                animalDie[n] = false;
                animalLEVEL[n] = 0;
            }

            // food (reset counter and process bar)
            for (int n = 0; n < DEFINE.FOOD_NUM; n++)
            {
                FCcounter[n] = 0;
                foodCT[n].Value = 50;
            }

            // release your food
            holdFood = -1;
        }

        private void bAnimal_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            
            if (holdFood != -1 && !animalDie[index(b)])
            {   // when you hold something and animal is live, see if you can feed the animal
                int tmp = DEFINE.MATCH[index(b), holdFood, animalLEVEL[index(b)]];
                bool spe = holdFood == (int)FOOD_KIND.ELEPHANT ? true : false;
                holdFood = -1;

                // special die situation
                if (tmp == -1)
                {
                    animalHUNGER[index(b)].Value = 0;
                    message.Text = "You kill your pet " + b.Text;
                    return;
                }

                // set processbar and show the message
                if (animalLEVEL[index(b)] < DEFINE.LEVEL_NUM)
                {   // normal situation (can add LOVE)
                    message.Text = animalLEVEL[index(b)].ToString() + " " + DEFINE.LEVEL_NUM.ToString();
                    animalHUNGER[index(b)].Value = animalHUNGER[index(b)].Value + tmp >= 100 ? 100 : animalHUNGER[index(b)].Value + tmp;
                    animalLOVE[index(b)].Value = animalLOVE[index(b)].Value + tmp >= 100 ? 100 : animalLOVE[index(b)].Value + tmp;
                    message.Text = "You feed the " + b.Text + "\n" + b.Text + "'s LOVE raise " + tmp + " unit\n";
                }
                else
                {   // max level situation (without add LOVE)
                    animalHUNGER[index(b)].Value = animalHUNGER[index(b)].Value + tmp >= 100 ? 100 : animalHUNGER[index(b)].Value + tmp;
                    message.Text = "You feed the " + b.Text + "\n" + b.Text + "' felt " + tmp + " more satisfied\n";
                }

                // special eat addition
                if (index(b) == (int)ANIMAL_KIND.SNAKE && spe && animalLEVEL[index(b)] >= DEFINE.LEVEL_NUM - 1)
                    message.Text = message.Text + "Wow!!, You eat an elephant!!!";
            }
            else if (animalDie[index(b)])
            {   // otherwise, show the message
                message.Text = message.Text + "\nYou can't feed a dead animal.\n";
            }


            // level up sitaution
            if (animalLOVE[index(b)].Value == 100) {
                animalLEVEL[index(b)]++;
                animalLOVE[index(b)].Value = 0;
                message.Text = message.Text + b.Text + " LEVEL UP to level " + animalLEVEL[index(b)];

                // show level on animals
                if (animalLEVEL[index(b)] == DEFINE.LEVEL_NUM)
                    b.Text = "LEVEL MAX";
                else
                    b.Text = "LEVEL " + animalLEVEL[index(b)];
            }
        }

        private void bFood_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (holdFood == -1 && foodCT[index(b)].Value >= DEFINE.EAT_PERCENT + DEFINE.UNKNOW_ERROR_OFFSET)
            {
                holdFood = index(b);
                foodCT[index(b)].Value -= DEFINE.EAT_PERCENT;
                message.Text = "You take the " + b.Text;
            } else if(holdFood != -1){
                message.Text = "You are greedy!\nYou are holding " + b_food[holdFood].Text + " now.\nYou can't hold another food.";
            } else {
                message.Text = "This one need more cold time";
            }
        }

        private int index(Button b) {
            for (int n = 0; n < DEFINE.ANIMAL_NUM; n++)
                if (b.Name == b_animal[n].Name)
                    return n;

            for (int n = 0; n < DEFINE.FOOD_NUM; n++)
                if (b.Name == b_food[n].Name)
                    return n;

            return -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // digest each animal's energy
            for (int n = 0; n < DEFINE.ANIMAL_NUM; n++)
            {
                AHcounter[n]++;
                if (AHcounter[n] >= DEFINE.ANIMAL_SCALE[n])
                {
                    animalHUNGER[n].Value = animalHUNGER[n].Value == 0 ? 0 : animalHUNGER[n].Value - 1;
                    AHcounter[n] = 0;
                }

                // dealing the die situation
                if (animalHUNGER[n].Value == 0 && !animalDie[n]) {
                    animalDie[n] = true;
                    animalLOVE[n].Value = 0;
                    ///////////////// change animal pic here
                    b_animal[n].Text = b_animal[n].Text + " IS DIE\nDie in level " + animalLEVEL[n].ToString();
                }
            }

            // add amount to each food
            for (int n = 0; n < DEFINE.FOOD_NUM; n++)
            {
                FCcounter[n]++;
                if (FCcounter[n] >= DEFINE.FOODCT_SCALE[n])
                {
                    foodCT[n].Value = foodCT[n].Value == 100 ? 100 : foodCT[n].Value + 1;
                    FCcounter[n] = 0;
                }
            }
        }
        
        private void Game6_FormClosed(object sender, FormClosedEventArgs e)
        {
            //wmp.close();
            parent.Show();
            //parent.resetSkin();
        }

        private void Game6_Load(object sender, EventArgs e)
        {

        }
    }

    public class DEFINE {
        public const int UNKNOW_ERROR_OFFSET = 6;
        public const int TIME_INTERVAL = 200;
        public const int FOOD_NUM = 5;
        public const int ANIMAL_NUM = 4;
        public const int LEVEL_NUM = 3;
        public const int EAT_PERCENT = 15;
        public static int[] FOODCT_SCALE = new int[FOOD_NUM] { 1, 3, 2, 7, 10};      // each 1 means 0.1 sec to add 1
        public static int[] ANIMAL_SCALE = new int[ANIMAL_NUM] { 2, 2, 3, 4};        // each 1 means 0.1 sec to sub 1
        private static int[] originalANIMAL_SCALE = new int[ANIMAL_NUM] { ANIMAL_SCALE[0], ANIMAL_SCALE[1], ANIMAL_SCALE[2], ANIMAL_SCALE[3] };
        public static void setPlayLevel(int unispeed) {
            for (int n = 0; n < ANIMAL_NUM; n++)
                ANIMAL_SCALE[n] = originalANIMAL_SCALE[n] * unispeed;
        }
        public static int[,,] MATCH = new int[ANIMAL_NUM, FOOD_NUM, LEVEL_NUM+1] {
            {
                { 20, 20, 20, 20},// { 4, 3, 2, 2},
                { 20, 20, 20, 20},// { 7, 5, 3, 3},
                { 5, 4, 3, 3},
                { 0, 0, 0, 0},
                {-1,-1, 0, 0}
            },{
                { 5, 6, 6, 6},
                { 1, 0, 0, 0},
                { 1, 0, 0, 0},
                { 1, 2, 2, 2},
                {-1, 0, 0, 0}
            },{
                { 3, 3, 3, 3},
                { 3, 3, 3, 3},
                { 3, 3, 3, 3},
                { 3, 3, 3, 3},
                {-1, 0, 0, 0}
            },{
                { 100, 100, 5, 5},
                { 3, 3, 5, 5},
                { 2, 2, 5, 5},
                { 0, 1, 5, 5},
                {-1,-1,30,30}
            }
        };
    }
}
