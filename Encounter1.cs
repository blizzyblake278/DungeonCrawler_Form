using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler2
{
    public partial class Encounter1 : Form
    {
        Player player;  //gets properties from player class
        //Weapon weapon;
        public Encounter1()
        {
            InitializeComponent();
        }
        int GoblinHealth = 36;
        private void AtkSword_Click(object sender, EventArgs e)
        {
            if(GoblinHealth != 0)
            {
               GoblinHealth = GoblinHealth - player.Attack();
               
            }
            else
            {
                //go to final scene/form
                //Finalscene finalscene = new Finalscene();
            }
        }
    }
}
