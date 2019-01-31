using System;
using System.Collections.Generic;

namespace Engine.Characters.CommandParser
{
    public class Parser
    {
        private bool QuitCalled { get; set; }
        public void Parse(string input)
        {
            Queue<string> commandQueue = new Queue<string>();
            string[] commands = input.Split(' ');
            foreach (string s in commands)
                commandQueue.Enqueue(s);

            parseCommand(commandQueue);
        }

        //TODO: Update parse system to allow for more flexible parsing.
        // nlp? Incorporate scripting to allow for flexibility?
        private void parseCommand(Queue<string> commandQueue)
        {
            string command = commandQueue.Dequeue();
            command = command.ToLower();
            switch (command)
            {
                /*
                 * Direction Commands
                 * 
                 */
                #region
                case "e":
                case "east":
                    Console.WriteLine("You have chosen to move east.");
                    break;
                case "w":
                case "west":
                    Console.WriteLine("You have chosen to move west.");
                    break;
                case "n":
                case "north":
                    Console.WriteLine("You have chosen to move north.");
                    break;
                case "s":
                case "south":
                    Console.WriteLine("You have chosen to move south.");
                    break;
                case "i":
                case "in":
                    Console.WriteLine("You have chosen to move inside.");
                    break;
                case "o":
                case "out":
                    Console.WriteLine("You have chosen to move outside.");
                    break;
                case "u":
                case "up":
                    Console.WriteLine("You have chosen to move up stairs.");
                    break;
                case "d":
                case "down":
                    Console.WriteLine("You have chosen to move down stairs.");
                    break;
                #endregion

                /*
                 * Utility Commands
                 * 
                 */
                #region
                case "q":
                case "quit":
                    QuitCalled = true;
                    break;

                case "l":
                case "look":
                    Console.WriteLine("You have chosen to look in the " + commandQueue.Dequeue() + " direction");
                    break;
                    //Possibly need to rethink how parsing commands is done because of possible two-word commands
                case "ql":
                case "quick":
                    Console.WriteLine("You have chosen to look quickly in the " + commandQueue.Dequeue() + " direction");
                    break;
                #endregion

                /*
                 * Combat Commands
                 * 
                 */
                #region
                case "attack":
                    Console.WriteLine("You have chosen to attack " + commandQueue.Dequeue());
                    break;

                case "swing":
                    Console.WriteLine("You have chosen to take a swing at " + commandQueue.Dequeue());
                    break;

                case "kick":
                    Console.WriteLine("You have chosen to kick " + commandQueue.Dequeue());
                    break;
                #endregion
                /*
                 * Default Command
                 * 
                 * An error used for when a main command is not recognized.
                 * Currently a generic error message, but may customized/randomize in future.
                 */
                default:
                    Console.WriteLine("A voice whispers to you, \"I do not understand.\"");
                    break;
            }
        }

        public bool HasQuit()
        {
            return QuitCalled;
        }
    }
}
