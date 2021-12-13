using System;

class Program
{
    public static void Main(string[] args)
    {
        //CL06 demonstrate use of boolian variable
        bool nameCheck = true;
        //this is for the wile loop the user used to decide to run auto repair or go to engine bay.
        bool computerPatch = true;
        bool stuck = true;
        bool engineFix = true;
        //CL08 this demonstrates a constsant.
        const bool greg = true;
        //CL05 Demonstrate use of a numeric variable
        int youDidIt = 0;
        //CL04 demonstrate use of string variable. CL01 'CL04' is an example of a line comment.
        string name;
        string scoops;
        Console.WriteLine("\t\tSpace Journey!\n");
        Console.WriteLine("\nThis is a text adventure game where you will be on a journey through SPAAAAAACE!\n");
        Console.WriteLine("\nDuring your adventure you may type 'help' or '?' ' to print a list of all available commands.\n");
        Console.WriteLine("\nPlease enter your name >> \n");
        while (nameCheck)
        {
            name = Console.ReadLine();
            if (name == "help" || name == "?")
            {
                Console.WriteLine("\nEnter a name");
                continue;
            }
            else
            {
                Console.WriteLine("\nHello " + name + "!");
                nameCheck = false;
            }
        }
        Console.WriteLine("\nYou are on the first manned mission to a recently discovered habitable moon of Saturn.");
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
        Console.Clear();
        //location 1
        Console.WriteLine("\n\t\t***** STASIS CHAMBER *****");
        Console.WriteLine("\nYou wake up dazed in your stasis pod.  Red lights are flashing and warning alrams are going crazy!");
        Console.WriteLine("\nComing to your senses you open your pod and step out into the stasis room.");
        Console.WriteLine("\nYou dash to the ships console to see what has happened.");
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\nOn the ships console you run a diagnostic of the ships vital functions and see that the engines quantum thruster has fatally malfunctioned!");

        while (computerPatch)
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nWould you like to attempt to use the computers auto repairs or head to the engine bay to check it out for yourself?");

            string repair = Console.ReadLine();
            if (repair == "help" || repair == "?")
            {
                Console.WriteLine("\n Enter any of the following inputs: auto repair, use computers auto repairs,  repair, run repair, run auto repair, run auto repair, engine bay, head to engine bay, leave");
                continue;
            }
            //CL15 This demonstrates the or operater.
            else if (repair == "a" || repair == "auto repair" || repair == "use computers auto repairs" || repair == "repair" || repair == "run repair" || repair == "run auto repair")
            {
                Console.WriteLine("\nThe auto repair system attempts to repair the thruster but gives you a 'repair failed' error message.");
                Console.WriteLine("\nWould you like to run the auto repair again? yes/no: ");
                while (stuck)
                {
                    //CL09 Demonstrates storing a value in a variable           
                    string sucker = Console.ReadLine();

                    if (sucker == "help" || sucker == "?")
                    {
                        Console.WriteLine("\nEnter 'yes' or 'no' ");
                        continue;
                    }
                    else if (sucker == "yes" || sucker == "a" || sucker == "auto repair" || sucker == "use computers auto repairs" || sucker == "repair" || sucker == "run repair" || sucker == "run auto repair")
                    {
                        Console.WriteLine("\nThe auto repair system attempts to repair the thruster but gives you a 'repair failed' error message.");
                        Console.WriteLine("\nWould you like to run the auto repair again?");
                        youDidIt = youDidIt + 1;
                        //CL10 This demonstrates using variables in artihmetic calculations.
                        if (youDidIt >= 12)
                        {
                            Console.WriteLine("\nIt worked! You repaired the ship.  Back to sleep!");
                            Console.WriteLine("YOU WIN!!");
                            Console.WriteLine("\nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            Environment.Exit(0);
                        }
                        continue;
                    }
                    else if (sucker == "no")
                    {
                        Console.Write("\nYou stop attempting auto repairs.\n");
                        stuck = false;
                    }
                    else
                    {
                        Console.Write("\nNot a viable option.");
                        Console.WriteLine("\nWould you like to run the auto repair again?");
                        continue;
                    }

                }
                continue;
            }
            else if (repair == "b" || repair == "engine bay" || repair == "head to engine bay" || repair == "leave")
            {
                Console.WriteLine("\nYou race down the cooridor towards the engine bay!");
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                Console.Clear();
                computerPatch = false;
            }
            else
            {
                Console.WriteLine("\nInvalid response.  Please try again or type 'help' or '?'.");
                continue;
            }
        }
        Console.WriteLine("\nAs you run to the engine bay you round a corner, and bump into your shipmate Greg.");
        Console.WriteLine("\nHey! I have a riddle for you! Can't let you past until you figure it out!");
        Console.WriteLine("\nOk what fruit is never happy?");

        while (greg)
        {
            string fruit = Console.ReadLine();
            if (fruit == "blueberry")
            {
                Console.WriteLine("\nThats right! Don't you just love riddles. Anyways I was just on the way to the kitchen to fill up my big gulp. See ya later.");
                Console.WriteLine("\nAs you spring towards the engine room, you think to yourself. I just hate Greg SO MUCH.");
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (fruit == "help" || fruit == "?")
            //CL02 Below is an example of a block comment.  
            /*
            This help print out does not give the user the answer
            but makes the riddle much easier to solve.
            */
            {
                Console.WriteLine("\nType in the most unhappy fruit you know. *maybe it's got the blues?");
                continue;
            }
            //CL17 This demonstrates the use of a not operater.
            else if (fruit != "blueberry")
            {
                Console.WriteLine("\nWell thats not right! I'll tell it again. what fruit is never happy?");
                continue;
            }
        }
        //location 4
        Console.WriteLine("*** ENGINE BAY DOOR ***");
        //the user must enter the correct format, and also an interactive item.  
        Console.WriteLine("\nYou reach the engine bay door, but the door is locked and you must enter the user name and passcode on the keypad!");
        passCode();
        Console.Clear();
        //area 2
        Console.WriteLine("\n\t\t***** ENGINE BAY *****");
        string bayChoice;
        Console.WriteLine("\nYou approach the quantum thruster and asses the situation.");
        Console.WriteLine("\nYou notice the couplings on the thruster module are rattling and shaking violently.");
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("As you look at the engine, Greg pops up next to you!");
        Console.WriteLine("He askes you 'Hey! Do you want to hear what my favorite animals are???'");
        bool iHateGreg = true;
        string answer;
        answer = Console.ReadLine();
        iHateGreg = answer == "yes";
        //CL21 Declare an array and assign initial values
        string[] Animals = { "Giraffe", "Squirrel", "wombat", "slow loris" };
        if (iHateGreg)
        {
            Console.WriteLine("Well, here they are!");
            //string [] Animals = {"Giraffe", "Squirrel", "wombat", "slow loris"};
            //CL19 This demonstrates the for loop
            foreach (string animal in Animals)
            {
                Console.WriteLine(animal);
            }
        }
        else
        {
            Console.WriteLine("TOO BAD!");
            //string [] Animals = {"Giraffe", "Squirrel", "wombat", "slow loris"};
            foreach (string animal in Animals)
            {
                Console.WriteLine(animal);
            }
        }
        Console.WriteLine("But, can you guess which of those is my MOST favorite???");//the second riddle where the user must select the correct animal form the array of Greg's favorite animals before they can continue

        string userGuess = gregAnimal(Animals);
        Console.WriteLine("I can't believe you knew my favorite was " + userGuess + " you're so smart!");
        Console.WriteLine("\nGreg leaves and you think to yourself 'I hate Greg so much...'");
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\nDo you want to use the dark matter phaser-hammer and hit the quantum thruster with all your might, use the quasar wrench to adjust the couplings or take a break and eat some space ice cream?");
        while (engineFix)
        {
            Console.WriteLine("Type 'a' to use the dark matter phaser-hammer.  Type 'b' to use the quasar wrench to adjust the couplings.  Type 'c' to take a break and eat some space ice cream. Type 'd' to head to the escape pod!");
            bayChoice = Console.ReadLine();
            switch (bayChoice)
            {
                case "a":
                    Console.WriteLine("\nAs your mighty blow strikes the engine everything stops shaking and seems to be working!  Then the engine explodes entirely and vaporizes you instantly!");
                    Console.WriteLine("\nYOU LOSE!");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case "b":
                    Console.WriteLine("\nYou snatch your trusty quasar wrench and tighten up the couplings on the quantum thruster module.");
                    Console.WriteLine("\nYou fixed it!  The warning lights stop flashing and you hear over the intercom, 'Systems Stable I'm proud of you!'");
                    Console.WriteLine("\nYou say 'Thanks Ship!' and go back to sleep.");
                    Console.WriteLine("\nYOU WIN");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case "c":
                    Console.WriteLine("\n\t\t***** SPACE KITCHEN *****");//Third area
                    Console.WriteLine("\nYou turn around and head toward the space kitchen to grab your favorite space ice cream 'comet caramel crunch'.");
                    Console.WriteLine("\nHow many scoops of ice cream do you take?");
                    int loopCount = 0;
                    bool parsed = false;
                    int numScoops = 0;
                    while (parsed == false)
                    {
                        if (loopCount > 0)
                        {
                            Console.WriteLine("Please enter a valid input");
                        }
                        scoops = Console.ReadLine();
                        //CL11 This demonstrates converting one data type to another.
                        parsed = Int32.TryParse(scoops, out numScoops);
                        loopCount++;
                    }
                    Console.WriteLine(numScoops + "\n! Wow! You're one hungry astronaut!");
                    Console.WriteLine("\nAs you finish the ice cream you hear over the intercom 'asteroid collision imminent!'");
                    Console.WriteLine("\nYou turn to the window beside you and see the asteroid careening toward the ship and think to yourself 'dang'.");
                    bool finalBool = true;
                    Console.WriteLine("Greg walks up as you eat your ice cream.");
                    Console.WriteLine("'Do you hate me?'");
                    string sadGreg = Console.ReadLine();
                    Console.WriteLine("Greg nods sagely. 'Do you think we will die?'");
                    string deadGreg = Console.ReadLine();
                    while (finalBool)
                    {
                        //CL14 This demonstrates an and operater.
                        if (sadGreg == "no" && deadGreg == "no")
                        {
                            Console.WriteLine("'Thats very nice of you. I always thought we were great friends.'");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Greg nods sagely once again. 'Yes this all makes sense.'");
                            break;
                        }
                    }
                    Console.WriteLine("\nThe asteroid hits the ship and you are blasted into space.");
                    Console.WriteLine("\nYOU LOSE");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case "d":
                    //location 5
                    bool parsley = true;
                    Console.WriteLine("***ESCAPE POD***");
                    Console.WriteLine("How many of each of these items would yu like to take with you?");
                    Console.WriteLine("MedKits");
                    string medKits = Console.ReadLine();
                    int medKitsNum;
                    parsley = Int32.TryParse(medKits, out medKitsNum);

                    Console.WriteLine("Food Rations");
                    string foodRations = Console.ReadLine();
                    int foodRationsNum;
                    parsley = Int32.TryParse(foodRations, out foodRationsNum);

                    Console.WriteLine("Tools");
                    string tools = Console.ReadLine();
                    int toolsNum;
                    parsley = Int32.TryParse(tools, out toolsNum);

                    Console.WriteLine("Greg");
                    string gregy = Console.ReadLine();
                    int gregNum;
                    parsley = Int32.TryParse(gregy, out gregNum);

                    escapePod(medKitsNum, foodRationsNum, toolsNum, gregNum);
                    break;
                case "help":
                case "?":
                    continue;
                default:
                    Console.WriteLine("Invalid engine fix input!  Please enter a valid engine fix.");
                    continue;
            }
        }
    }
    //CL28/29 This is a method with no parameters and no return value (void)
    public static void passCode()
    {
        bool goodCode = true;
        int enteredCode;
        string[] passCodes = new string[2];
        /*user name / 4 digit pass code*/
        Console.WriteLine("Enter user name and 4 digit passcode");
        string password = Console.ReadLine();
        //CL22 This demonstrates adding elements to an array
        passCodes[0] = password;
        while (goodCode)
        {
            int codeLen;
            Console.WriteLine("Enter Code");
            string numCode = Console.ReadLine();
            Int32.TryParse(numCode, out enteredCode);
            //CL26 This demonstrates the .Length property
            codeLen = numCode.Length;
            Console.WriteLine();
            if (enteredCode == 0)
            {
                Console.WriteLine("Please enter a valid 4 digit code");
                continue;
            }
            else if (codeLen < 4 || codeLen > 4)
            {
                Console.WriteLine("Please enter a valid 4 digit code");
                continue;
            }
            else
            {
                //CL22 This demonstrates adding elements to an array
                passCodes[1] = numCode;
                //CL27 This demonstates useing a FOREACH loop to loop through an array
                foreach (string i in passCodes)
                {
                    Console.WriteLine(i);
                }
                //CL23 This Demonstrates using an array element within a statement.
                Console.WriteLine(passCodes[0] + " your code " + passCodes[1] + " is valid!");
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                break;
            }

        }
    }
    //CL30/CL32/CL33/CL34 This method requires a single arguement, it returns a value, it is passed array values, it passes the parameter(Animals) by reference.
    public static string gregAnimal(string[] Animals)
    {
        bool animalChoice = true;
        string userGuess = "";
        //CL24 This while loop has the user search the array for the given value "Wombat" 
        while (animalChoice)
        {
            userGuess = Console.ReadLine();

            if (userGuess == Animals[2])
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else
            {
                Console.WriteLine("WRONG try guessing again from my list of animals");
                Console.WriteLine(Animals[0] + ", " + Animals[1] + ", " + Animals[2] + ", " + Animals[3]);
                continue;
            }

        }
        //CL35 This demonstrates returning a reference from a method.
        return userGuess;
    }
    //CL31/CL36 This is an overloaded method with multiple optional parameters.
    public static void escapePod(int var1, int var2, int var3, int var4)
    {
        int sum = var1 + var2 + var3 + var4;
        Console.WriteLine("The total number of things you will take with you is {0}", sum);
        Console.WriteLine("You gather your selected supplies and blast off in the escape pod!");
        Console.WriteLine("You crash land on an alien planet, YOU WIN");
        //location 6
        Console.WriteLine("***ALIEN PLANET***");
        Console.WriteLine("TO BE CONTINUED!!!");
        Environment.Exit(0);
    }
}