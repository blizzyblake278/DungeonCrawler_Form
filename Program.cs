using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler2
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       public static Player player;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Weapon sword = new Weapon("Hel Fire", 6);
            player = new Player("", 36, 6, sword);

            Application.Run(new Form1());

            
        }
    }
    public class Player
    {

       
        private Weapon sword;


        public string PlayerName { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }


        public Player(string playername, int health, int strength, Weapon s)
        {
            this.PlayerName = playername;  //gets character name from form1 and makes it the username throughout the game. 
            //this.PlayerName = playername;
            this.Health = health;
            this.Strength = strength;
            this.sword = s;
        }
        public Player(string playername)
        {
            this.PlayerName = playername;  //gets character name from form1 and makes it the username throughout the game. 

        }
        public int Attack()
        {
            return sword.Attack(this.Strength);
        }


    }

    public class Weapon
    {
        public string Name { get; set; } = "Hel Fire";
        public int AtkDmg { get; set; } = 4;

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
    
 
}
