﻿using System;
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
        static Form menuScreen = new MainMenuForm();

        int NoOfTimesAttempted = 0;

        static public string user;

        public LogOnForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            catch
            {
                MessageBox.Show("Sorry, an error has occured. Please try again.");
            }

            
        }

        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxUsername.Text == "R-Williams" && tbxPassword.Text == "ironman")
                {
                    MessageBox.Show("Access Granted. Details are correct.");
                    user = "r";
                    this.Hide();
                    menuScreen.Show();

                }

                else if (tbxUsername.Text == "D-Patel" && tbxPassword.Text == "hulk")
                {
                    MessageBox.Show("Access Granted. Details are correct.");
                    user = "d";
                    this.Hide();
                    menuScreen.Show();

                }

                else if (tbxUsername.Text == "D-Jones" && tbxPassword.Text == "hawkeye")
                {
                    MessageBox.Show("Access Granted. Details are correct.");
                    user = "d";
                    this.Hide();
                    menuScreen.Show();

                }

                else if (tbxUsername.Text == "PM-Smith" && tbxPassword.Text == "widow")
                {
                    MessageBox.Show("Access Granted. Details are correct.");
                    user = "pm";
                    this.Hide();
                    menuScreen.Show();

                }

                else
                {
                    MessageBox.Show("Sorry, an error has occured. Username/Password is incorrect. Please try again.");
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                    NoOfTimesAttempted++;


                }

                if (NoOfTimesAttempted == 3)
                {
                    MessageBox.Show("Number of atttempts exceeded. Please try again later.");
                    tbxUsername.Enabled = false;
                    tbxPassword.Enabled = false;
                    btnConfirmDetails.Visible = false;
                    tmrSuspend.Enabled = true;
                }
            }

            catch
            {
                MessageBox.Show("Sorry, an error has occured. Please try again.");
            }
        }
    }
}
