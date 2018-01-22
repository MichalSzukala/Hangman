using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hangman
{
    /// <summary>
    /// SelectingWord class selects one random word from the provided list of words 
    /// </summary>
    class SelectingWord
    {


        /// <summary>
        /// Provides random number
        /// </summary>
        /// <param name="maxNumber">number of all words in the word list</param>
        private int RandomNumber(int maxNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, maxNumber);

            return randomNumber; 
        }



        /// <summary>
        /// Calculates number of words in the list of words
        /// </summary>
        private int NumberOfWords()
        {
            int numberOfWords = 1;
            return numberOfWords;

        }



        /// <summary>
        /// Takes all the words from the WordList txt file and choosing randomly one word from that list 
        /// </summary>
        public string TheWord()
        {
            //provide string which contain all of the words from "WordList.txt" file
            string wordListString = Properties.Resources.WordList;

            //spliting wordListString to the array.  Splits on the new line break
            string[] arrayOfWords = wordListString.Split(new[] { Environment.NewLine },StringSplitOptions.None);

            int randomNumber = RandomNumber(arrayOfWords.Length);
            //System.Diagnostics.Debug.WriteLine(arrayOfWords[randomNumber]);

            return arrayOfWords[randomNumber];
        }
    }
}
