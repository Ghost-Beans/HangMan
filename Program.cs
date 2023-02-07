using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        bool playerWon = false;
        bool winEqual(char[] playerInput, string word)
        {
            //Console.WriteLine("Cheese");

            for (int k = 0; k < playerInput.Length; k++)
            {
                if (word[k] == playerInput[k])
                {
                    continue;
                }
                else
                {
                   // Console.WriteLine("Cheese_6000");
                    return false;
                }
            }
            playerWon = true;
            //Console.WriteLine("Cheese_03");
            return true;

        }

        string word;// what needs to be found
        char[] playerInput;//what is replaced i guess, don't really know why I named it named this and it confuses me greatly
        int score = 0, incorrect = 0;
        bool outOfLives = false;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("This is Hang Man. A quite morbid word game.");

        string[] listWords = new string[5];

        listWords[0] = "sheep";
        listWords[1] = "bovine";
        listWords[2] = "seacow";
        listWords[3] = "goat";
        listWords[4] = "turtle";


        Random pickRand = new Random();// selects random word
        var index = pickRand.Next(0, 4);// the range intex for the random word
        word = listWords[index];// defines index as 'word'

        playerInput = new char[word.Length];
        Console.WriteLine("As your only hint, all these words are animals.");
        Console.Write("Please enter your guess. One letter at a time please: ");
        Console.ForegroundColor = ConsoleColor.White;// makes the colors white again

        Console.WriteLine();

        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("               | ");
        Console.WriteLine("               | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");

        Console.WriteLine();//enters input on the next line


        for (int k = 0; k < word.Length; k++)//detecting each letter and making it a symbol
            playerInput[k] = '?';

        Console.WriteLine(playerInput);//shows hidden word
        Console.WriteLine();

        /*
        Nullable<char> playerCharChoice = Console.ReadLine()?[0];
        if (playerCharChoice.HasValue)
        {
            Console.WriteLine(playerCharChoice);
        }
        */

        do
        {
            // player input
            char playerGuess = char.Parse(Console.ReadLine());

            //with initiating what is false, then the character check for the string
            bool found = false;
            for (int k = 0; k < word.Length; k++)
            {
                if (playerGuess == word[k])
                {
                    playerInput[k] = playerGuess;
                    found = true; // found the letter
                }

            }
            //Console.WriteLine("RREEEERRRERERERE");
            if (!found)
            {
                incorrect++;
                score--;
                switch (incorrect)
                {
                    case 1:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /            \\");
                        Console.WriteLine("  O            | ");
                        Console.WriteLine("               | ");
                        Console.WriteLine("               | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Wrong guess! " +
                            "\nImagine if your fate was decided on by someone needing to guess letters.");
                        Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("bad");
                        Console.WriteLine(playerInput);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /            \\");
                        Console.WriteLine("  O            | ");
                        Console.WriteLine("  |            | ");
                        Console.WriteLine("               | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("OOOH, LOOK! He's a stick figure! " +
                            "\nIt would be a shame if he were taken from this world too soon.");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Console.WriteLine("bad_2");
                        Console.WriteLine(playerInput);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /            \\");
                        Console.WriteLine("  O            | ");
                        Console.WriteLine(" /|            | ");
                        Console.WriteLine("               | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Half way to death. You should guess your animals better. " +
                            "\nFunny how even though the head's there, he's not dead until the body is complete.");
                        Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("bad_3");
                        Console.WriteLine(playerInput);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /            \\");
                        Console.WriteLine("  O            | ");
                        Console.WriteLine(" /|\\           | ");
                        Console.WriteLine("               | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Next we start on the legs." +
                            "\nThat last one wasn't that funny at all. As stated above, a morbid game.");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Console.WriteLine("bad_4");
                        Console.WriteLine(playerInput);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /            \\");
                        Console.WriteLine("  O            | ");
                        Console.WriteLine(" /|\\           | ");
                        Console.WriteLine(" /             | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Oof, one more chance or you're out buddy.");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Console.WriteLine("bad_5");
                        Console.WriteLine(playerInput);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("   ___________");
                        Console.WriteLine("  /           \\");
                        Console.WriteLine("  O           | ");
                        Console.WriteLine(" /|\\          | ");
                        Console.WriteLine(" / \\          | ");
                        Console.WriteLine(" --------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("And there's the dead body. . ." +
                            "\nWell, then. Better luck next time!");
                        Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("bad_6");
                        Console.WriteLine(playerInput);
                        outOfLives = true;
                        Console.WriteLine();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Lucky guess. . .");
                Console.WriteLine(playerInput);
                Console.WriteLine();
            }

            if (outOfLives)
            {
                break;
            }
           

        } while (!winEqual(playerInput, word));

        //end of game score
        if (playerWon)
        {
            score += 10;
        }

        if (score < 0)
        {
            score = 0;
        }

        if (playerWon)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Congratulations! You Won. Our stick man lives to see another day!\n" +
                "Total score: " + score);
            Console.ForegroundColor = ConsoleColor.White;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You Lost. Here's a score to see how badly you lost.\n" +
                "Total score: " + score);
            Console.WriteLine("The correct word was " + word+".");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
