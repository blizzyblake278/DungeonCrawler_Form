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

namespace DungeonCrawler2
{
    public partial class Form1 : Form
    {

        //sets user input from txtEmail.Text to UserEmail
        public static string UserEmail { get; set; }
        public static string UserName { get; set; }
       
     
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //email is here from user
            //txtEmail.Text is string of email entered

            //MessageBox.Show(String.Format("Email: {0}\n UserName: {1}", UserEmail, UserName));
            

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            //sets users input as UserEmail and returns it to 
            //public static property UserEmail above
            UserEmail = this.txtEmail.Text;   
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            UserName = this.txtName.Text;
        }
    }
}
