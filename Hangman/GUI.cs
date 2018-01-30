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
    /// <summary>
    /// GUI class is resposible for interaction with user
    /// </summary>
    public partial class GUI : Form
    {
        private Word word;
        private Label[] arrayOfLabels;

        public GUI()
        {
            InitializeComponent();
            InitializeGUI();
            
        }

        /// <summary>
        /// Initilize the GUI
        /// </summary>
        private void InitializeGUI()
        {
            textBoxLetter.Clear();
            labelMessage.Text = String.Empty;
            arrayOfLabels = startArrayOfLabels();

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

        /// <summary>
        /// event handler for OK button
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        /// <summary>
        /// event handler for New Game button
        /// </summary>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            startNewGame();

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
                startNewGame();
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

        /// <summary>
        /// creates array which contains all the labels covering the word user is guessing.  All the labels are geting empty string as a value
        /// </summary>
        private Label[] startArrayOfLabels()
        {
            Label[] arrayOfLabels = {labelLetter0, labelLetter1, labelLetter2, labelLetter3, labelLetter4, labelLetter5, labelLetter6, labelLetter7};
            for (int i = 0; i < arrayOfLabels.Length; i++)
                arrayOfLabels[i].Text = String.Empty;

            return arrayOfLabels;
        }


        private void showRightNumberOfLabels()
        {

        }
        
        
        /// <summary>
        /// displays right number of letters to guess and starts the new game
        /// </summary>
        private void startNewGame()
        {
            word = new Word();
            int lengthOfWord = word.WordLength();

            for (int i = 0; i < lengthOfWord; i++)
                arrayOfLabels[i].Text = "__";

        }
        


       
       

    

       
    }
}
