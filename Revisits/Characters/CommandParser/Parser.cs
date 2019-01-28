using System;
using System.Collections.Generic;

namespace Revisits.Characters.CommandParser
{
    class Parser
    {
        public void Parse(string input)
        {
            Queue<string> commandQueue = new Queue<string>();
            string[] commands = input.Split(' ');
            foreach (string s in commands)
                commandQueue.Enqueue(s);

            parseCommand(commandQueue);
        }

        private void parseCommand(Queue<string> commandQueue)
        {
            string command = commandQueue.Dequeue();
            command = command.ToLower();
            switch (command)
            {
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
            }
        }

        public bool HasQuit()
        {
            return true;
        }
    }
}
