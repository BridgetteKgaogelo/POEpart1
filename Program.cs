using System;
using System.Media;
using System.Threading;

class Chatbot
{ 
    public static void PlayVoiceGreeting()
    {
        string audioFilePath = "path_to_your_wav_file\\welcomeMessage.wav";
        // Added namespace for MediaPlayer
        try
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri(audioFilePath, UriKind.RelativeOrAbsolute));
            player.Play();

            // Pause to allow the sound to finish (adjust duration as necessary)
            Thread.Sleep(5000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }
    }

    public static void DisplayAsciiArt()
    {
        string asciiArt = @"
   ____ ___  ___ _____   ____      _        _      _    _  _______ 
  / ___/ _ \/ _ \_   _| | __ )  ___| |_ __ _| |_ __| |__(_) ___|_  ___
 | |  | | | | | | | |   |  _ \  / _ \ __/ _` | __/ _| '_ \ | |   \__ \
 | |__| |_| | |_| | |   | |_) |  |  __/  | (_| |  | (_| | |  ___ __) |
  \____\___/ \___/  |   |____/    \___|\__\__,_|\__\__,_|__| |____/|___/
        ";

        Console.WriteLine(asciiArt);
    }

    public static void GreetUser()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to the Cybersecurity Awareness Bot.");
    }

    public static void RespondToUser(string userInput)
    {
        if (userInput.ToLower().Contains("how are you"))
        {
            Console.WriteLine("I'm doing well, thank you for asking!");
        }
        else if (userInput.ToLower().Contains("what's your purpose"))
        {
            Console.WriteLine("My purpose is to help you stay safe online by providing cybersecurity tips and guidance.");
        }
        else if (userInput.ToLower().Contains("password safety"))
        {
            Console.WriteLine("Always use strong, unique passwords for each of your accounts. Consider using a password manager.");
        }
        else
        {
            Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
        }
    }

    public static void ValidateAndRespond(string userInput)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("I didn't quite understand that. Could you rephrase?");
        }
        else
        {
            RespondToUser(userInput);
        }
    }

    public static void PrintHeader(string header)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"==== {header} ====");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintDivider()
    {
        Console.WriteLine(new string('-', 50));
    }

    public static void TypeWriterEffect(string text, int delay = 100)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);  // Typing effect delay
        }
        Console.WriteLine();
    }

    public static void DisplayGreeting()
    {
        PrintHeader("Cybersecurity Awareness Bot");
        PrintDivider();
        TypeWriterEffect("Hello, and welcome to the Cybersecurity Awareness Bot!");
        TypeWriterEffect("I am here to help you stay safe online.");
        Console.WriteLine();
    }

    static void Main()
    {
        // Play the greeting
        PlayVoiceGreeting();

        // Display Greeting
        DisplayGreeting();

        // Greet the user
        GreetUser();

        // Conversation loop
        while (true)
        {
            PrintDivider();
            TypeWriterEffect("Ask me a question (type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                TypeWriterEffect("Goodbye! Stay safe online.");
                break;
            }

            ValidateAndRespond(userInput);
        }
    }
}



