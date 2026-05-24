
/*
    Erwin Mashobane
    ST10073464
*/
using System;
using System.Collections;
using System.Data;

namespace CybersecurityAwarenessChatbot.Classes

{
    
    class ChatBot
    {
        List<(string message, DateTime time)> conversationHistory = new List<(string, DateTime)>();
        public string UserName { get; set; }

        UIHelper ui = new UIHelper();

        VoicePlayer voice = new VoicePlayer();

        Responses responses = new Responses();

        public void Start()
        {
            // Show ASCII Logo
            ui.ShowLogo();

            // Play welcome audio
            voice.PlayGreeting();

            AskUserName();

            // Small pause for effect
            Thread.Sleep(500);

            //  welcome message
            Console.WriteLine($"\nHey {UserName}! Welcome to SecureWin");

            Console.WriteLine("\nYou can chat with me about staying safe online, including:");
            Console.WriteLine("     Creating strong passwords");
            Console.WriteLine("     Spotting phishing scams");
            Console.WriteLine("     Safe and smart browsing");

            Console.WriteLine("\nGo ahead and ask me anything related to online safety!\n");
            Console.WriteLine("Type 'exit' anytime to quit.\n");

            ChatLoop();
        }

        void AskUserName()
        {
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                // warning message when user enters empty name
                Console.WriteLine("Name cannot be empty. Please try again.");
                UserName = Console.ReadLine();
            }

            // Trim spaces and capitalize first letter
            UserName = UserName.Trim();
            UserName = char.ToUpper(UserName[0]) + UserName.Substring(1).ToLower();
        }

        void ChatLoop()
        {
            string input = "";

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");

                input = Console.ReadLine().ToLower();
                //  Case-InsensitiveComparer handling
                input = input.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    // Check for empty input and prompt user to enter a valid question
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                // Exit condition
                if (input == "exit")
                {
                    Console.Write("\nBot: Would you like to see your conversation before exiting? (yes/no): ");
                    string choice = Console.ReadLine().ToLower().Trim();

                    while (choice != "yes" && choice != "no")
                    {
                        Console.Write("Please type 'yes' or 'no': ");
                        choice = Console.ReadLine().ToLower().Trim();
                    }

                    if (choice == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n===== Conversation History =====\n");

                        for (int i = 0; i < conversationHistory.Count; i++)
                        {
                            var entry = conversationHistory[i];

                            string time = entry.time.ToString("HH:mm:ss");

                            // Alternate colors for user & bot
                            if (i % 2 == 0)
                                Console.ForegroundColor = ConsoleColor.White;   // User
                            else
                                Console.ForegroundColor = ConsoleColor.Green;   // Bot

                            Console.WriteLine($"[{time}] {entry.message}");
                        }

                        Console.WriteLine("\n================================");
                        conversationHistory.Clear(); // clear history after displaying
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nBot: Goodbye {UserName}! Stay safe online and keep winning");
                    break;
                }

                // Get response from Responses class and display it     
                Console.ForegroundColor = ConsoleColor.Green;
                string botReply = responses.GetResponse(input);

                conversationHistory.Add(("You: " + input, DateTime.Now));
                conversationHistory.Add(("Bot: " + botReply, DateTime.Now));

                Console.WriteLine("Bot: " + botReply);
            }
        }
    }
}


