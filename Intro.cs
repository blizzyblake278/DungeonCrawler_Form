using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Media;
using DungeonCrawler2.Properties;

namespace DungeonCrawler2
{

    public partial class Intro : Form
    {


        SoundPlayer LoopA = new SoundPlayer(Resources.Loopable_A_2020_09_15___Brutality___David_Fesliyan);
        SoundPlayer LoopB = new SoundPlayer(Resources.Loopable_B_2020_09_15___Brutality___David_Fesliyan);


        public Intro()
        {
            InitializeComponent();
        }
        public int counter = 0;
        private void ContinueButton_Click(object sender, EventArgs e)
        {
           //int counter = 0;
           if(counter != 3)
            {
                if(counter == 0)
                {
                    TxtBox2.Visible = true;
                    TxtBox1.Visible = false;
                    LoopA.Play();
                    counter++;
                }
                else if(counter == 1)
                {
                    TxtBox3.Visible = true;
                    TxtBox2.Visible = false;
                    LoopB.Play();
                    counter++;
                }
                else if (counter == 2)
                {
                    Encounter1 encounter = new Encounter1();
                    encounter.Show();
                    Hide();

                }

            }
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
