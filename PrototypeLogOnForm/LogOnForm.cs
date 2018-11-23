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
    public partial class LogOnForm : Form
    {
        static Form menuScreen = new MainMenuForm(); //New Instance of Main Menu.

        int NoOfTimesAttempted = 0; //Record of Login Attempts.

        static public string user;

        public LogOnForm()
        {
            InitializeComponent();
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

        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxUsername.Text == "R-Williams" && tbxPassword.Text == "ironman") //User Accounts.
                {
                    MessageBox.Show("Access Granted. Details are correct."); //Confirmation of Successful Login.
                    user = "r"; //Sets User Level.
                    this.Hide(); //Hides Login Form.
                    menuScreen.Show(); //Displays Main Menu.

                }

                else if (tbxUsername.Text == "D-Patel" && tbxPassword.Text == "hulk") //User Accounts.
                {
                    MessageBox.Show("Access Granted. Details are correct."); //Confirmation of Successful Login.
                    user = "d"; //Sets User Level.
                    this.Hide(); //Hides Login Form.
                    menuScreen.Show(); //Displays Main Menu.

                }

                else if (tbxUsername.Text == "D-Jones" && tbxPassword.Text == "hawkeye") //User Accounts.
                {
                    MessageBox.Show("Access Granted. Details are correct."); //Confirmation of Successful Login.
                    user = "d"; //Sets User Level.
                    this.Hide(); //Hides Login Form.
                    menuScreen.Show(); //Displays Main Menu.

                }

                else if (tbxUsername.Text == "PM-Smith" && tbxPassword.Text == "widow") //User Accounts.
                {
                    MessageBox.Show("Access Granted. Details are correct."); //Confirmation of Successful Login.
                    user = "pm"; //Sets User Level.
                    this.Hide(); //Hides Login Form.
                    menuScreen.Show(); //Displays Main Menu.

                }

                else
                {
                    MessageBox.Show("Sorry, an error has occured. Username/Password is incorrect. Please try again."); //Error Message for Incorrect Password/Username.
                    tbxUsername.Clear(); //Clears Textbox.
                    tbxPassword.Clear(); //Clears Textbox.
                    NoOfTimesAttempted++; //Add onto Recorded Attempts.


                }

                if (NoOfTimesAttempted == 3) //Number of Attempts Reached.
                {
                    MessageBox.Show("Number of atttempts exceeded. Please try again later."); //Display Message stating Suspension of Process.
                    tbxUsername.Enabled = false; //Disables Form Control.
                    tbxPassword.Enabled = false; //Disables Form Control.
                    btnConfirmDetails.Visible = false; //Disables Form Control.
                    tmrSuspend.Enabled = true; //Starts Timer.
                    
                }

            }

            catch
            {
                MessageBox.Show("Sorry, an error has occured. Please try again."); //Try/Catch Error Message.
            }
            
        }

        private void tmrSuspend_Tick(object sender, EventArgs e) //End of Timer.
        {
            tbxUsername.Enabled = true; //Re-enables Form Control.
            tbxPassword.Enabled = true; //Re-enables Form Control.
            btnConfirmDetails.Visible = true; //Re-enables Form Control.
            tmrSuspend.Enabled = false; //Disables Timer.
            NoOfTimesAttempted = 0; //Resets Attempts Counter.
        }
    }
}
