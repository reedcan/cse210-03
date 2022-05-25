//Handles correct/incorrect guess logic, similar to Seeker from Hide and Seek.
//Has a method that will display a list of "_" depending on how many letters in the word recieved from Word.cs
//Has a method that will take a user inputed letter and decide if it is in the word, and if it is it will update the corresponding "_" with that letter

using System;


namespace Parachute
{
    
    public class Guesser
    {
        Word words = new Word();
        Stickman stickman = new Stickman();

        List<string> lines = new List<string>{};

        List<string> wordList = new List<string>();
        string randomWord = "";
        
        public Guesser()
        {
            randomWord = words.getRandomWord();
            wordList = words.convertRandomWord(randomWord);
        }

        public void GetWords()
         {
            foreach (string letter in wordList)
            {
                lines.Add("_");
            }          
         }


        public int checkGuess(string guess, int incorrectGuesses)
        {

            if(wordList.Contains(guess))
            {
                int index = -1;
                foreach(string letter in wordList)
                {
                    ++index;
                    if(guess==letter)
                    {
                        lines[index] = letter;
                    }
                }
                return incorrectGuesses;
            }
            else
            {
                ++incorrectGuesses;
                return incorrectGuesses;
            }
        }


        public bool completedWordCheck()
        {
            if (lines.SequenceEqual(wordList))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayLines()
        {
            foreach(string letter in lines)
            {
                Console.Write(letter);
            }
        }

        public void displayWordList()
        {
            Console.Write("\nThe answer was: ");
            foreach(string letter in wordList)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}

        