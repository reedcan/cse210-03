//Damian's domainian
namespace Parachute {
    public class Stickman {

    
        string completeStickman =       "        ____________            \n"     +
       "      /    |    |    \\          \n"     +
       "     /     |    |     \\         \n"     +
       "     \\     |    |     /         \n"     +
       "      \\    |    |    /          \n"     +
       "       \\   |    |   /           \n"     +
       "        \\  |    |  /            \n"     +
       "         \\ |    | /             \n"     +
       "          \\|    |/              \n"     +
       "           |----|               \n"     +
       "           | (O)|               \n"     +
       "           |  | |               \n"     +
       "           |----|               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string oneIncorrect =       "        ____________            \n"     +
       "      /    |         \\          \n"     +
       "     /     |          \\         \n"     +
       "     \\     |          /         \n"     +
       "      \\    |         /          \n"     +
       "       \\   |        /           \n"     +
       "        \\  |       /            \n"     +
       "         \\ |      /             \n"     +
       "          \\|     /              \n"     +
       "           |----|               \n"     +
       "           | (O)|               \n"     +
       "           |  | |               \n"     +
       "           |----|               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string twoIncorrect =       "        ____________            \n"     +
       "      /    |                   \n"     +
       "     /     |                   \n"     +
       "     \\     |                   \n"     +
       "      \\    |                   \n"     +
       "       \\   |                   \n"     +
       "        \\  |                   \n"     +
       "         \\ |                   \n"     +
       "          \\|                   \n"     +
       "           |----|               \n"     +
       "           | (O)|               \n"     +
       "           |  | |               \n"     +
       "           |----|               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;


       string threeIncorrect =  
       "       _____________            \n"    + 
       "      /                        \n"     +
       "     /                         \n"     +
       "     \\                         \n"     +
       "      \\                        \n"     +
       "       \\                       \n"     +
       "        \\                      \n"     +
       "         \\                     \n"     +
       "          \\                    \n"     +
       "           |----|               \n"     +
       "           | (O)|               \n"     +
       "           |  | |               \n"     +
       "           |----|               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string fourIncorrect =       
       "        _____________            \n"    + 
       "                              \n"     +
       "                              \n"     +
       "                              \n"     +
       "                              \n"     +
       "                              \n"     +
       "          OH NO                    \n"     +
       "                              \n"     +
       "                              \n"     +
       "                          \n"     +
       "             (O)               \n"     +
       "              |                \n"     +
       "            -----               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;


       string fiveIncorrect =
       "             ___            \n"     +
       "            (x_x)               \n"     +
       "              |                \n"     +
       "            -----               \n"     +
       "              |      DED           \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     +
       "-------------------------------" ;
       

        public Stickman()
        {

        }

        public void drawStickman(int numberOfIncorrectGuesses)
        {
            //if input in list then numberofincorrectguesses stays, else number of incorrect guesses++
            if (numberOfIncorrectGuesses == 0)
            {
                Console.WriteLine(completeStickman);
            }
            else if (numberOfIncorrectGuesses == 1)
            {
                Console.WriteLine(oneIncorrect);
            }
            else if (numberOfIncorrectGuesses == 2)
            {
                Console.WriteLine(twoIncorrect);
            }
            else if (numberOfIncorrectGuesses == 3)
            {
                Console.WriteLine(threeIncorrect);
            }
            else if (numberOfIncorrectGuesses == 4)
            {
                Console.WriteLine(fourIncorrect);
            }
            else
            {
                Console.WriteLine(fiveIncorrect);
            }
        }
    }
}
