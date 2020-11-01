﻿using Microsoft.SqlServer.Server;
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
        //Player player; //gets properties from player class

        public Player player1;

        //Weapon weapon; //gets properties from weapon class
        public Encounter1()
        {
            InitializeComponent();
            
        }
        
        private void AtkSword_Click(object sender, EventArgs e)
        {
            
            int GoblinHealth = 36;
            int GoblinAttack = 2;
            if (GoblinHealth != 0)
            {
               GoblinHealth -= player1.Attack();
                player1.Health -= GoblinAttack;

                //MessageBox.Show(String.Format("Goblin Health = {0}\n Player Health = {1}", GoblinHealth, player1.Health));
                //ResultsLabel.Visible = true;
                
                //below should display text and results from attack
                //ResultsLabel.Text = Format.ToString("{0} Attacks the goblin. The goblin is at {1} HP. \n {2} is at {3} HP", player.PlayerName, GoblinHealth, player.PlayerName, player.Health);
            }
            else
            {
                MessageBox.Show("Error");
                //go to final scene/form
                //Finalscene finalscene = new Finalscene();
            }
        }
    }
}
