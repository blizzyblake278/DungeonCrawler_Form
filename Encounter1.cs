using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static DungeonCrawler2.Program;

namespace DungeonCrawler2
{
    public partial class Encounter1 : Form
    {



        

        //Weapon weapon; //gets properties from weapon class
        public Encounter1()
        {
            InitializeComponent();
            
        }
        
        
        private void AtkSword_Click(object sender, EventArgs e)
        {


            if (goblin.Health != 0)
            {
                player.Health -= goblin.Attack();
                goblin.Health -= player.Attack();
                ResultsLabel.Visible = true;
                ResultsLabel.Text = String.Format("{0} health is at {1}\n {2} health is at {3}", player.PlayerName, player.Health, goblin.Name, goblin.Health);
            }
            else if( goblin.Health == 0)
            {
                Finalscene finalscene = new Finalscene();
                Hide();
                finalscene.Show();
            }
            else if(player.Health == 0)
            {
                MessageBox.Show("YOU'RE DEAD!!!!!");
            }
               
               
            }
    }
}
