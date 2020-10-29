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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        public int counter = 0;
        private void ContinueButton_Click(object sender, EventArgs e)
        {
           //int counter = 0;
            while(counter != 2)
            {
                if(counter == 0)
                {
                    TxtBox2.Visible = true;
                    counter++;
                }
                else if(counter == 1)
                {
                    TxtBox3.Visible = true;
                    counter++;
                }
                else
                {
                    MessageBox.Show("create form 3");
                }
               
            }
        }
    }
}
