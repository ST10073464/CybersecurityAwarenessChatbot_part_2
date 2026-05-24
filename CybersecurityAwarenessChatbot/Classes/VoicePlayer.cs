/*
    Erwin Mashobane
    ST10073464
*/

using System.Media;

namespace CybersecurityAwarenessChatbot.Classes
{
    class VoicePlayer
    {
        // Plays a greeting sound when the chatbot starts
        public void PlayGreeting()
        {
            try
            {
                
                SoundPlayer player = new SoundPlayer(Properties.Resources.hello);

                player.PlaySync();

                // Small pause for effect
                Thread.Sleep(500);
            }
            catch (Exception)
            {
                Console.WriteLine("Audio file could not be played.");

                // Small pause for effect
                Thread.Sleep(500);
            }
        }
    }
}