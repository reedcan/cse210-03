//Handles correct/incorrect guess logic, similar to Seeker from Hide and Seek.
//Has a method that will display a list of "_" depending on how many letters in the word recieved from Word.cs
//Has a method that will take a user inputed letter and decide if it is in the word, and if it is it will update the corresponding "_" with that letter

using System;


namespace Parachute
{
    
    public class Guesser
    {
        Word words = new Word();
        
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
            string word = words.getRandomWord();
            List<string>wordList = words.convertRandomWord(word);
            foreach (string letter in word)
            {
                List<string>lines = new List<string>();
                lines.Add("_");
            }


            return words.getRandomWord();
         }

         private string CheckGuess(guess)
         {
             // if guess is in random generated word
             // then convert line into latter

         }

    //     private string UpdateLines();
    //     {

    //     }
    }
}