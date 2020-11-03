using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static DungeonCrawler2.Program;

namespace DungeonCrawler2
{
    public partial class Form1 : Form
    {


        //sets user input from txtEmail.Text to UserEmail

        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public DateTime UserBday { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //email is here from user
            //txtEmail.Text is string of email entered

            //MessageBox.Show(String.Format("Email: {0}\n UserName: {1}\nUser's Birthday: {2}", UserEmail, UserName, UserBday));
           // MessageBox.Show(player.PlayerName);
           
            Intro intro = new Intro();
            Hide();
            intro.Show();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            //sets users input as UserEmail and returns it to 
            //public static property UserEmail above
            UserEmail = this.txtEmail.Text;   
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            //sets users input as UserName and returns it to 
            //auto prop of UserName
            //thhis username will also be used as player's name in game
            player.PlayerName = this.txtName.Text;
            //UserName = this.txtName.Text;
        }

        private void Dt_Picker_ValueChanged(object sender, EventArgs e)
        {
            //UserBday = this.dt_Picker.Value.Date;
            var dateTimeStr = this.dt_Picker.Value;
            dateTimeStr.ToString("MM/dd/yyyy");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
