/*
    Erwin Mashobane
    ST10073464
*/
using System;
using System.Threading;

namespace CybersecurityAwarenessChatbot.Classes
{
    class UIHelper
    {
        // Method to display the ASCII art logo and welcome message
        public void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==================================================");
            Console.WriteLine("         CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==================================================");
            Console.WriteLine(@" _____                           _    _ _       
/  ___|                         | |  | (_)      
\ `--.  ___  ___ _   _ _ __ ___ | |  | |_ _ __  
 `--. \/ _ \/ __| | | | '__/ _ \| |/\| | | '_ \ 
/\__/ /  __/ (__| |_| | | |  __/\  /\  / | | | |
\____/ \___|\___|\__,_|_|  \___| \/  \/|_|_| |_|
                                                
                                                ");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("         Stay Secure. Stay Winning Online.");
            Console.WriteLine("==================================================\n");

            Thread.Sleep(800);

            Console.ResetColor();
        }
        public void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}