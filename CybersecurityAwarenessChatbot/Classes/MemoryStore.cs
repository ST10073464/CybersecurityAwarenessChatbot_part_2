/*
    Erwin Mashobane
    ST10073464
*/

namespace CybersecurityAwarenessChatbot.Classes
{
    // Stores chatbot memory and user preferences.
    public class MemoryStore
    {
        // User's name.
        public string UserName { get; set; } = "";

        // User's favourite cybersecurity topic.
        public string FavouriteTopic { get; set; } = "";

        // Stores the previous topic.
        public string LastTopic { get; set; } = "";

        // Stores conversation history.
        public List<string> ConversationHistory { get; set; }

        // Constructor
        public MemoryStore()
        {
            ConversationHistory = new List<string>();
        }

        // Adds chat history.
        public void AddConversation(string message)
        {
            ConversationHistory.Add(message);
        }

        // Returns a personalised sentence.
        public string GetPersonalisedMessage()
        {
            if (!string.IsNullOrEmpty(FavouriteTopic))
            {
                return $"As someone interested in {FavouriteTopic}, you should stay informed about online threats.";
            }

            return "";
        }
    }
}
