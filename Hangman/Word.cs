using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    /// <summary>
    /// Provides implementation for quessing a letter by the user
    /// </summary>
    class Word
    {
        private char[] wordCharArray;
        private SelectingWord selectingWord;

        public Word()
        {
            selectingWord = new SelectingWord();
            StartTheWord();
        }

        /// <summary>
        /// Gets the word from SelectingWord class and changes this word to array of characters
        /// </summary>
        private void StartTheWord()
        {
            string word = selectingWord.TheWord();
            wordCharArray = word.ToCharArray();
        }

        /// <summary>
        /// Provides number of letter in the word
        /// </summary>
        public int WordLength()
        {
            return wordCharArray.Length;
        }


        /// <summary>
        /// Searches for the letter in the array of letters.  It return index of letter when if it finds it, otherwise return -1
        /// </summary>
        /// <param name="letter">Searched letter in the array</param>
        public int positionOfLetter(char letter)
        {
            int number = -1;
            
            for(int i = 0; i < wordCharArray.Length; i++)
            {
                if (wordCharArray[i] == Char.ToLower(letter))
                {
                    number = i;
                    wordCharArray[i] = '1';
                    return number;
                }
            }
            return number;
        }

        /// <summary>
        /// checks if user guessed all the letters, and won the game
        /// </summary>
        public bool WiningTest()
        {
            bool test = true; 

            for (int i = 0; i < wordCharArray.Length; i++)
            {
                if (wordCharArray[i] != '1')
                    return false;
            }

            return test;
        }

        /// <summary>
        /// shows char at specific index
        /// </summary>
        /// <param name="index">index of the char</param>
        /// <returns></returns>
        public char checkLetterOnIndex(int index)
        {

            if (index < WordLength())
                return wordCharArray[index];
            else
                return '1';
        }
    }
}
