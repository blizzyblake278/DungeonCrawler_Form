using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using DungeonCrawler2.Properties;

namespace DungeonCrawler2
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Player player;
        public static Enemy goblin;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Random rnd = new Random();

            int atkEnemy = rnd.Next(4,10);
           
            Weapon sword = new Weapon("Hel Fire", 4);
            player = new Player("", 36, 6, sword);
            goblin = new Enemy("Goblin", 36, atkEnemy);
            
            
            //set background music here for dark_castle. 
            //under properties set Copy > Output dir. & Copy Always
            // also build action to content. this will make VS copy music to output directory always.
            SoundPlayer soundplayer = new SoundPlayer(Resources.dark_castle);

            soundplayer.PlayLooping();
            

            Application.Run(new Form1());




            

        }
    }
    public class Player
    {

        private Weapon sword;

        public string PlayerName { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }


        public Player(string playername, int health, int strength, Weapon sword)
        {
            this.PlayerName = playername;  //gets character name from form1 and makes it the username throughout the game. 
            //this.PlayerName = playername;
            this.Health = health;
            this.Strength = strength;
            this.sword = sword;
        }
        public Player(string playername)
        {
            this.PlayerName = playername;  //gets character name from form1 and makes it the username throughout the game. 

        }
        public int Attack()
        {
            return this.sword.Attack(this.Strength);
        }


    }

    public class Weapon
    {
        public string Name { get; set; }
        public int AtkDmg { get; set; }

        public Weapon(string name, int attack)
        {
            this.Name = name;
            this.AtkDmg = attack;

        }

        //Attack function that will take users STR and Sword Strength
        public int Attack(int strength)
        {
            int result = strength + this.AtkDmg; // AtkDmg is the weapons Strength
            return result;
        }
    }
    public class Enemy
    {

        
        
        public string Name { get; set; }
        public int AtkDmg { get; set; }
        public int Health { get; set; }

        public Enemy(string name, int health, int atkdmg)
        {
            this.Name = name;
           this.AtkDmg = atkdmg;
            this.Health = health;
        }

        private int Attack(int atkdmg)
        {
            return this.AtkDmg = atkdmg;
        }

        public int Attack()
        {
            return this.Attack(AtkDmg);
        }

    }


 
}
