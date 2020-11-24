using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DungeonCrawler2.Properties;
using static DungeonCrawler2.Program;

namespace DungeonCrawler2
{
    public partial class Encounter1 : Form
    {



        // Add music here for fight. 
        public Encounter1()
        {
            InitializeComponent();
            
        }
       


        //figure out how to add wav files to folder and access them in teh directory so it's not local. 
        private void AtkSword_Click(object sender, EventArgs e)
        {
            //SoundPlayer soundplayer = new SoundPlayer(@"C:\Users\magic\source\repos\DungeonCrawler2\Resources\sword_slash_wav.wav");
            //soundplayer.Play();


            // added sowrdslash to resources.resx file to access within compiled folder. || also added using <namespace>.Properties at the top to access this within the compiled file
            SoundPlayer soundplayer = new SoundPlayer(Resources.SwordSlash_wav);
            soundplayer.Play();




            if (goblin.Health != 0)
            {
                goblin.Health -= player.Attack();
                player.Health -= goblin.Attack();
                ResultsLabel.Visible = true;
                ResultsLabel.Text = String.Format("{0} health is at {1}\n {2} health is at {3}", player.PlayerName, player.Health, goblin.Name, goblin.Health);
                if(goblin.Health <= 0)
                {
                    Finalscene finalscene = new Finalscene();
                    Hide();
                    finalscene.Show();
                }
            }
            //else if (goblin.Health <= 0)
            //{
            //    Finalscene finalscene = new Finalscene();
            //    this.Close();
            //    finalscene.Show();
            //}
            else
            {
                YoureDead dead = new YoureDead();
                Hide();
                dead.Show();
            }



        }
       
        private void AtkFist_Click(object sender, EventArgs e)
        {
            

            //SoundPlayer soundplayer = new SoundPlayer(@"C:\Users\magic\source\repos\DungeonCrawler2\Resources\punch.wav");
            //soundplayer.Play();

            // added punch to resources.resx file. also added using <namespace>.Properties at the top to access this within the compiled file
            SoundPlayer soundplayer = new SoundPlayer(Resources.punch);
            soundplayer.Play();


            if (goblin.Health != 0)
            {
                goblin.Health -= player.Attack();
                player.Health -= goblin.Attack();
                ResultsLabel.Visible = true;
                ResultsLabel.Text = String.Format("{0} health is at {1}\n {2} health is at {3}", player.PlayerName, player.Health, goblin.Name, goblin.Health);
                if (goblin.Health <= 0)
                {
                    Finalscene finalscene = new Finalscene();
                    Hide();
                    finalscene.Show();
                }
            }
           
            else
            {
                YoureDead dead = new YoureDead();
                Hide();
                dead.Show();
            }
        }
    }
}
