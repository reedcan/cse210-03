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
        private IO iO = new IO();

        public static int numberOfIncorrectGuesses = 0;
        Stickman stickman = new Stickman();
        Guesser Guesser = new Guesser();
        List<string> lines = Guesser.GetWord();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {   
                stickman.drawStickman(numberOfIncorrectGuesses);
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        

        /// <summary>
        /// Gets users input for the guess
        /// </summary>
        private void GetInputs()
        {
            string guess = iO.ReadText("\nGuess a letter [a-z]: ");
        
        }

        
        /// <summary>
        /// updates all the information using the input that was recieved
        /// </summary>
        private void DoUpdates()
        {
            
            Guesser.CheckGuess(guess, )
        }

        /// <summary>
        /// Gives all the information needed to get the player ready to start their next turn/ guess
        /// </summary>
        private void DoOutputs()
        {
            
        }
    }
}