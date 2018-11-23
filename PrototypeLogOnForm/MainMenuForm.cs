using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeLogOnForm
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (LogOnForm.user == "pm") //Statements for Levels of Access.
                {


                    btnPatients.Visible = true; //True == Shows Button.
                    btnStaff.Visible = true;
                    btnAppointment.Visible = true;
                    btnSearch.Visible = true;
                    btnGenerate.Visible = true;

                    LogOnForm.user = ""; //Resets user after every log-on.
                }

                else if (LogOnForm.user == "d") //Statements for Levels of Access.
                {
                    btnPatients.Visible = true;
                    btnStaff.Visible = true;
                    btnAppointment.Visible = true;
                    btnSearch.Visible = true;
                    btnGenerate.Visible = false; //False == Hides Button.

                    LogOnForm.user = "";
                }

                else if (LogOnForm.user == "r") //Statements for Levels of Access.
                {
                    btnPatients.Visible = true;
                    btnStaff.Visible = true;
                    btnAppointment.Visible = true;
                    btnSearch.Visible = false;
                    btnGenerate.Visible = false;

                    LogOnForm.user = "";
                }
            }

            catch
            {
                MessageBox.Show("Sorry, an error has occured. Please try again."); //Try/Catch Error Message.
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) //Popup Message Box Confiming Leave.
                {
                    Application.Exit(); //Exits Application.
                }
            }

            catch
            {
                MessageBox.Show("Sorry, an error has occured. Please try again."); //Try/Catch Error Message.
            }
            
                
        }
    }
}
