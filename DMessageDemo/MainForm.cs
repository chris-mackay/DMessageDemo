using System;
using System.Windows.Forms;
using DialogMessage;

namespace DMessageDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showMessage_Click(object sender, EventArgs e)
        {
            if (DMessage.ShowMessage(

                 // Window Title
                 "Window Title",

                 // Main Instruction
                 "Want to learn how to write your own message box?",

                 // Dialog buttons
                 DMessage.MsgButtons.YesNo,

                 // Dialog Icons
                 DMessage.MsgIcons.Question,

                 // Content
                 "In this project we will learn the logic necessary " +
                 "to write your own dialog message box in Windows")

                 // Checks DialogResult of the button clicked by user
                 == DialogResult.Yes)
           
                // Show the Windows standard MessageBox to test result
                MessageBox.Show("You clicked Yes!");

            else

                MessageBox.Show("You clicked No!");
        }
    }
}
