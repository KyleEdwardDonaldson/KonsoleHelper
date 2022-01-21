﻿using System;

namespace KonsoleHelper
{
    public class KonsoleHelper
    {
        public void WriteLine(string message, int linesAfter = 1)
        {
            // Writes message into console
            Console.WriteLine(message);

            // Adds lines after message
            for (var i = 0; i < linesAfter; i++)
            {
                Console.WriteLine();
            }
        }

        public T AskForInput<T>(string request, string invalidInputMessage = "Unable to parse input.")
        {
            T userInputAsT = (T)Activator.CreateInstance(typeof(T));
            bool successfulCast = false;
            while (!successfulCast)
            {
                // Requests information from user
                WriteLine(request, 0);
                var userInput = Console.ReadLine();

                try
                {
                    // Attempts to convert user input to requested type
                    userInputAsT = (T)Convert.ChangeType(userInput, typeof(T));
                    successfulCast = true;
                }
                catch
                {
                    // Prompts the user that their input was unable to be parsed
                    successfulCast = false;
                    WriteLine(invalidInputMessage, 1);
                }
            }

            return userInputAsT;
        }
    }
}