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

namespace DungeonCrawler2
{
    public partial class Form1 : Form
    {

        
        
        
            public string UserEmail { get; set; }
            public string UserName { get; set; }
            public string UserBday { get; set; }

      

        public Form1()
        {

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //var userInfo = new List<User> {
            //    new User(email: user.UserEmail.ToString(), username: player.PlayerName.ToString(),birthday: user.UserBday.ToString())
            //};

            //ExcelMapper mapper = new ExcelMapper();

            //var newFile = @"C:\DungeonCrawler.xlsx";
            //mapper.Save(newFile, userInfo, "LoginInfo", true);


            //var dateTimeStr = this.dt_Picker.Value;
            //string birthday = dateTimeStr.ToString("MM/dd/yyyy");

            //Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application() ;

            //Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet);
            //Worksheet ws = (Worksheet)xls.ActiveSheet;


            //xls.Visible = true;

            //ws.Cells[1, 1] = "Email";
            //ws.Cells[1, 2] = "Username";
            //ws.Cells[1, 3] = "Birthday";

            //ws.Cells[2, 1] = txtEmail.Text;
            //ws.Cells[2, 2] = txtName.Text;
            //ws.Cells[2, 3] = birthday;



            //if (!WarriorBox.Checked && !WizardBox.Checked && !Rangerbox.Checked )
            //{
            //    MessageBox.Show("Must choose a class");
            //}
           
                Intro intro = new Intro();
                Hide();
                intro.Show();
            

           
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                    //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                   // {
                        var dateTimeStr = this.dt_Picker.Value;
                        string birthday = dateTimeStr.ToString("MM/dd/yyyy");

                        Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();

                        Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)xls.ActiveSheet;


                        xls.Visible = false;
                        ws.Cells[1, 1] = "Email";
                        ws.Cells[1, 2] = "Username";
                        ws.Cells[1, 3] = "Birthday";

                        ws.Cells[2, 1] = txtEmail.Text;
                        ws.Cells[2, 2] = txtName.Text;
                        ws.Cells[2, 3] = birthday;

                        xls.Visible = true;
                    
                        btnRegister.Visible = false;
                        btnContinue.Visible = true;
                    //}
                }
            }
            
            
            


        }
    }
}
