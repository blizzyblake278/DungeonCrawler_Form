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

        private Weapon weapon;
        public string PlayerName { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        
        public Player (string playername, int health, int strength)
        {
            this.PlayerName = playername;
            this.Health = health;
            this.Strength = strength;
        }
        
        public int Attack()
        {
            return weapon.Attack(this.Strength);
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
}
