//Handles correct/incorrect guess logic, similar to Seeker from Hide and Seek.
//Has a method that will display a list of "_" depending on how many letters in the word recieved from Word.cs
//Has a method that will take a user inputed letter and decide if it is in the word, and if it is it will update the corresponding "_" with that letter

using System;


namespace Parachute
{
    
    public class Guesser
    {
        List<Word> words = new List<Word>();
        public Guesser()
        {
            // if user guess = letter from random word from parachute
            // if player guess = item in the list
            // make list with blank lines
            // if guess matches letter then append letter to blank line list
        }
         private string GetWord()
         {
            // Call and return the getRandomWord function
            Word word = new Word();
            word.getRandomWord();

            return word.getRandomWord();
         }

        private string UpdateLines()
        {

        }
    }
}