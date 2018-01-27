using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            InitializeGUI();
        }


        private void InitializeGUI()
        {
            textBoxLetter.Clear();
            labelMessage.Text = "To start new game press New Game";
        }


        /// <summary>
        /// Checks if user provide letter as an input
        /// </summary>
        private bool ReadInput()
        {
            bool okChar = false;
            bool okAll = false;
            char letter = '1';
            string input = textBoxLetter.Text;
            okChar = char.TryParse(input, out letter);

            if (okChar)
                okAll = char.IsLetter(letter);
            if (okAll)
                return okAll;
            else
            {
                GiveMessage("Provide a letter");
                return false;
            }
               
        }

        /// <summary>
        /// Custom error message
        /// </summary>
        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        /// <summary>
        /// popping up confirmation window
        /// </summary>
        private DialogResult ConfirmationWindow(string message)
        {
            DialogResult result = MessageBox.Show(message, "Confirmation Window", MessageBoxButtons.OKCancel);
            return result;

        }

        /// <summary>
        /// Event handler for Menu/New
        /// </summary>
        private void newMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = ConfirmationWindow("Do you really want to start new game?");
            if (result == DialogResult.OK)
            {
                InitializeGUI();
            }
        }

        /// <summary>
        /// event handler for Menu/About
        /// </summary>
        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutBoxInfo aboutMe = new AboutBoxInfo();
            aboutMe.Show();
        }

        /// <summary>
        /// event handler for Menu/Exit
        /// </summary>
        private void exitMenu_Click(object sender, EventArgs e)
        {

            DialogResult result = ConfirmationWindow("Do you really want to close program?");
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
