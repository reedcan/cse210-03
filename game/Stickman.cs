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
       "      /    |    |    \\          \n"     +
       "     /     |    |     \\         \n"     +
       "     \\     |    |     /         \n"     +
       "      \\    |    |    /          \n"     +
       "       \\   |    |   /           \n"     +
       "        \\  |    |  /            \n"     +
       "         \\ |    | /             \n"     +
       "          \\|    |/              \n"     +
       "           |----|               \n"     +
       "             (O)|               \n"     +
       "             \\| |               \n"     +
       "            ----|               \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string twoIncorrect =       "        ____________            \n"     +
       "      /    |    |    \\          \n"     +
       "     /     |    |     \\         \n"     +
       "     \\     |    |     /         \n"     +
       "      \\    |    |    /          \n"     +
       "       \\   |    |   /           \n"     +
       "        \\  |    |  /            \n"     +
       "         \\ |    | /             \n"     +
       "          \\|    |/              \n"     +
       "           |----|               \n"     +
       "             (O)                \n"     +
       "             /|\\                 \n"     +
       "            ----                \n"     +
       "              |                 \n"     +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string threeIncorrect =       
       "        ____________            \n"      +
       "      /    |    |    \\          \n"     +
       "     /     |    |     \\         \n"     +
       "     \\     |    |     /         \n"     +
       "      \\    |    |    /          \n"     +
       "       \\   |    |   /           \n"     +
       "        \\  |    |  /            \n"     +
       "         \\ |    | /             \n"     +
       "          \\|    |/              \n"     +
       "           |----|               \n"      +
       "                                \n"      +
       "                                \n"      +
       "            \\(O)/               \n"      +
       "             \\|/                 \n"    +
       "              |                 \n"      +
       "             / \\                \n"     +
       "            /   \\               \n"     ;

       string fourIncorrect =       
       "       \\   |    |   /           \n"     +
       "        \\  |    |  /            \n"     +
       "         \\ |    | /             \n"     +
       "          \\|    |/              \n"     +
       "           |----|               \n"      +
       "                                \n"      +
       "                                \n"      +
       "                                \n"      +
       "            \\(X)/               \n"      +
       "             \\|/                 \n"    +
       "              |                 \n"      +
       "             / \\                \n"     +
       "____________/___\\_______________\n"     ;
       

        public Stickman()
        {

        }

        public void drawStickman(int numberOfIncorrectGuesses)
        {
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
            else
            {
                Console.WriteLine(fourIncorrect);
            }
        }
    }
}
