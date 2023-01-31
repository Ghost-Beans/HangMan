using System;
using System.Runtime.CompilerServices;
/*
 * current problems: program does not detect when the word is correct and end itself
 * scores are not being calculated(i do not think they are because the progam does not sense the end to show the wouldbe scores
 * 
 * i 
 */

class Program
{
    static void Main(string[] args)
    {
        string word;// what needs to be found
        char[] playerInput;//what is replaced i guess, don't really know why I named it named this and it confuses me greatly
        int score = 0, incorrect = 0;

        Console.WriteLine("This is Hang Man. A quite morbid word game.");

        string[] listWords = new string[5];

        listWords[0] = "sheep";
        listWords[1] = "noat";
        listWords[2] = "boat";
        listWords[3] = "moat";
        listWords[4] = "broat";


        Random randGen = new Random();// selects random word
        var index = randGen.Next(0, 4);// the range intex for the random word
        word = listWords[index];// defines index as 'word'

        playerInput = new char[word.Length];
        Console.Write("Please enter your guess. One letter at a time please: ");
        Console.WriteLine();//enters input on the next line


        for (int k = 0; k < word.Length; k++)//detecting each letter and making it a symbol
            playerInput[k] = '?';

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

            if (!found)
            {
                incorrect++;
                score--;
                switch (incorrect)
                {
                    case 1:
                        Console.WriteLine("bad");
                        Console.WriteLine(playerInput);
                        break;
                    case 2:
                        Console.WriteLine("bad_2");
                        Console.WriteLine(playerInput);
                        break;
                    case 3:
                        Console.WriteLine("bad_3");
                        Console.WriteLine(playerInput);
                        break;
                    case 4:
                        Console.WriteLine("bad_4");
                        Console.WriteLine(playerInput);
                        break;
                    case 5:
                        Console.WriteLine("bad_5");
                        Console.WriteLine(playerInput);
                        break;
                    case 6:
                        Console.WriteLine("bad_6");
                        Console.WriteLine(playerInput);
                        break;
                }

            }
            else
            {
                Console.WriteLine("Good");
                Console.WriteLine(playerInput);
                score++;
                playerInput.Equals(word);
                Console.WriteLine(score);
            }

        } while (incorrect < 6 && !playerInput.Equals(word));

        //end of game score
        if (playerInput.Equals(word))
        {
            score += 10;
        }

        if (score < 0)
        {
            score = 0;
        }

        if (playerInput.Equals(word))
        {
            Console.WriteLine("Congratulations! You Won. Total score: " + score);
        }

        else
        {
            Console.WriteLine("You Lost. Total score: " + score);
        }


    }
}


/*
    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("               | ");
        Console.WriteLine("               | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");
    }
  
    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine("               | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");
    }

    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine("  |            | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");
    }

    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine(" /|            | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");
    }

    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine(" /|\\          | ");
        Console.WriteLine("               | ");
        Console.WriteLine(" --------------");
    }

    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine(" /|\\          | ");
        Console.WriteLine(" /             | ");
        Console.WriteLine(" --------------");
    }

    {
        Console.WriteLine("   ___________");
        Console.WriteLine("  /            \\");
        Console.WriteLine("  O            | ");
        Console.WriteLine(" /|\\          | ");
        Console.WriteLine(" / \\          | ");
        Console.WriteLine(" --------------");

    */






