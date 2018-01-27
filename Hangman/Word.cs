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
            string word = selectingWord.TheWord();
            wordCharArray = word.ToCharArray();
        }




    }
}
