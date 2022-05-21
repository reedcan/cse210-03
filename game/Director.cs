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
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        
        private void GetInputs()
        {
            string guess = iO.ReadText("\nGuess a letter [a-z]: ");
        
        }

        
        private void DoUpdates()
        {
            
        }

        
        private void DoOutputs()
        {
            
        }
    }
}