namespace Parachute
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private bool isPlaying = true;
        private IO io = new IO();

        private Guesser guesser = new Guesser();
        private Stickman stickman = new Stickman();
        Word word = new Word();
        string guess = "";
        int incorrectGuesses;
        bool wordCompleted = false;


       
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            
            guesser.GetWords();
            stickman.drawStickman(incorrectGuesses);
            guesser.displayLines();

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        
        private void GetInputs()
        {
            guess = io.ReadText("\nPlease guess a letter: ");
        }

        
        private void DoUpdates()
        {
            incorrectGuesses = guesser.checkGuess(guess, incorrectGuesses);
            wordCompleted = guesser.completedWordCheck();
            if (incorrectGuesses >= 4)
            {
                Console.WriteLine("\n\nYou died!");
                guesser.displayWordList();
                isPlaying = false;

            }
            if (wordCompleted)
            {
                Console.WriteLine("\n\nCongratulations! You guessed it right!");
                isPlaying = false;
            }
            
        }


        private void DoOutputs()
        {
            stickman.drawStickman(incorrectGuesses);
            if (isPlaying)
            {
                guesser.displayLines();
            }
        }
    }
}