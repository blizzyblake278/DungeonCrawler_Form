using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Player 
    {
        private Form1 login;
        private Weapon sword;
        public string PlayerName { get; set; }
        public int Health { get; set; } = 36;
        public int Strength { get; set; } = 6;
        
        public Player (string playername, int health, int strength, Weapon s)
        {
            this.login.UserName = playername;  //gets character name from form1 and makes it the username throughout the game. 
           // this.PlayerName = playername;
            this.Health = health;
            this.Strength = strength;
            this.sword = s;
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
