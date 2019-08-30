using System;
using static System.Console;

namespace HolaMundo
{
    class Program
    {
        static void WriteMenu(string output)
        {
            Clear();
            WriteLine("Choose a language:\n1 = English\n2 = Spanish\n3 = French\n");
            WriteLine("To exit, press 0 (zero) key.\n\n");
            WriteLine(output);
        }
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int choice = 0;
            while (0 == 0)
            {
                WriteMenu(message);
                input = ReadLine();
                while (!int.TryParse(input, out choice))
                {
                    message = "Invalid input.\nPlease choose a number between 1 and 3.";
                    WriteMenu(message);
                    input = ReadLine();
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        message = "Hello World! My Name is Matt Obert!";
                        WriteMenu(message);
                        break;
                    case 2:
                        message = "¡Hola Mundo! ¡Mi Nombre es Matt Obert!";
                        WriteMenu(message);
                        break;
                    case 3:
                        message = "Bonjour le Monde! Je m'appelle Matt Obert!";
                        WriteMenu(message);
                        break;
                    default:
                        message = "Please choose a number between 1 and 3 next time.";
                        WriteMenu(message);
                        break;
                }
            }
        }
    }
}
