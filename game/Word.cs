//Responsible for word generation. Has a list of words, a method that will return a random word from that list, and a method that will return a string of letters from
//that word.
using System;
using System.Collections.Generic;


namespace Parachute
{
    public class Word
    {
       
        List<string> wordList = new List<string>{
            "agree", "already", "arrive", "baby", "branch", "busy", "cake", "clean", "contain",
            "dance", "decrease", "duck", "education", "enhance", "explain", "fact", "fever", "future",
            "game", "glass", "grandmother", "hair", "happy", "hurry", "idea", "important", "island",
            "jelly", "juice", "just", "keep", "king", "knock", "ladder", "lately", "lesson", "machine",
            "measure", "moon", "name", "neither", "number", "object", "opposite", "outside", "page",
            "perfect", "present", "queen", "question", "quick", "radio", "remember", "ruler", "sad",
            "someone", "strange", "table", "telephone", "travel", "under", "useful", "usually",
            "vegetable", "village", "visit", "wait", "water", "world", "yard", "yesterday", "young",
            "zero", "zoo"
        };

        string randomWord = "";

        public Word()
        {
            
        }

        public string getRandomWord()
        {
            Random random = new Random();
            randomWord = random.Next(0, wordList.Count);

            return randomWord;
        }
    }
}