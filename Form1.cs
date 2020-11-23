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
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Ganss.Excel;
using static System.Console;
using static DungeonCrawler2.Program;
using  DungeonCrawler2.Properties;

namespace DungeonCrawler2
{
    public partial class Form1 : Form
    {

        
        
        
            public string UserEmail { get; set; }
            public string UserName { get; set; }
            public string UserBday { get; set; }


        System.Media.SoundPlayer soundplayer = new System.Media.SoundPlayer();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
           
                Intro intro = new Intro();
                intro.Show();
            Hide();



        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            //sets users input as UserEmail and returns it to 
            //public static property UserEmail above
            //UserEmail = this.txtEmail.Text;
            UserEmail = this.txtEmail.Text;
            
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            //sets users input as UserName and returns it to 
            //auto prop of UserName
            //thhis username will also be used as player's name in game
            player.PlayerName = this.txtName.Text;
            
        }

        private void Dt_Picker_ValueChanged(object sender, EventArgs e)
        {
            
            //var dateTimeStr = this.dt_Picker.Value;
            //string birthday = dateTimeStr.ToString("MM/dd/yyyy");


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

            while (!btnContinue.Visible)
            {
                if (!WarriorBox.Checked && !WizardBox.Checked && !Rangerbox.Checked)
                {
                    MessageBox.Show("Must choose a class");
                    break;
                }
                else
                {
                    
                        var dateTimeStr = this.dt_Picker.Value;
                        string birthday = dateTimeStr.ToString("MM/dd/yyyy");

                        Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();   //insatance of xls to be xls file

                        Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)xls.ActiveSheet;


                    

                        xls.Visible = false;  //shows excel sheet to test data has been input correctly
                        
                    //create headers on xls sheet
                         ws.Cells[1, 1] = "Email"; 
                        ws.Cells[1, 2] = "Username";
                        ws.Cells[1, 3] = "Birthday";
                    
                    //puts data in row then column
                        ws.Cells[2, 1] = txtEmail.Text;
                        ws.Cells[2, 2] = txtName.Text;
                        ws.Cells[2, 3] = birthday;
                    
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(saveFileDialog1.FileName);  //creates save as dialog box to save file as filename that was stated in the properties of savedialog1
                       
                    }
                   

                        // used the below to check the excel sheet to ensure it showed correctly.                           
                        //xls.Visible = true;
                    
                        btnRegister.Visible = false;
                        btnContinue.Visible = true;
                    
                }
            }
            
            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
