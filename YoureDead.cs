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
    public partial class YoureDead : Form
    {
        public YoureDead()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ////create instance of savefile
            //SaveFileDialog saveFile = new SaveFileDialog();
            ////save file type as
            //saveFile.Filter = "Excel File | *.xls";
            //saveFile.Title = " Save an Excel File";
            //saveFile.ShowDialog();
            //if(saveFile.FileName != "")
            //{
            //    saveExcelFile(saveFile.FileName);
            //}
            Application.Exit();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
