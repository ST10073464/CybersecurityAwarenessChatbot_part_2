/*
    Erwin Mashobane
    ST10073464
*/
using System;
using System.Collections;
using System.Data;

namespace CybersecurityAwarenessChatbot.Classes
{
    // Main chatbot engine.
    // Controls memory, sentiment, keyword recognition, and conversation flow.
    public class ChatBot
    {
        private readonly KeywordResponder keywordResponder;
        private readonly SentimentDetector sentimentDetector;
        private readonly MemoryStore memoryStore;

        private readonly Random random;

        private bool awaitingName = true;

        private readonly List<string> fallbackResponses;

        private string LastMatchedKeyword = "";

        // Constructor

        public ChatBot()
        {
            keywordResponder = new KeywordResponder();
            sentimentDetector = new SentimentDetector();
            memoryStore = new MemoryStore();

            random = new Random();

            fallbackResponses = new List<string>
            {
                "I'm not sure I understand yet. Try asking about passwords, scams, or privacy.",
                "Could you rephrase that? I can help with cybersecurity topics.",
                "Ask me about phishing, malware, passwords, or online safety."
            };
        }

        // Initial greeting message.
        public string GetGreeting()
        {
            return "👋 Welcome to SecureWin!\n\nWhat is your name?";
        }

        // Main chatbot processing logic.
        public string ProcessInput(string input)
        {
            input = input.ToLower();

            // Capture user name
            if (awaitingName)
            {
                memoryStore.UserName = input;

                awaitingName = false;

                return $"😊 Nice to meet you, {memoryStore.UserName}!\n\n" +
                       $"You can ask me about:\n" +
                       $"🔒 Passwords\n" +
                       $"🎣 Phishing\n" +
                       $"🛡️ Privacy\n" +
                       $"💻 Malware\n" +
                       $"⚠️ Scams";
            }

            // Follow-up conversations
            if (
                input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more") ||
                input.Contains("continue")
                )
            {
                return keywordResponder.GetFollowUpResponse();
            }

            // Store favourite topic
            if (input.Contains("interested in"))
            {
                foreach (string keyword in keywordResponder.GetAllKeywords())
                {
                    if (input.Contains(keyword))
                    {
                        memoryStore.FavouriteTopic = keyword;

                        return $"Great! I'll remember that you're interested in {keyword}.";
                    }
                }
            }

            // Sentiment detection
            Sentiment sentiment = sentimentDetector.Detect(input);

            // Keyword responce
            string keywordResponse = keywordResponder.GetResponse(input);

            if (!string.IsNullOrEmpty(keywordResponse))
            {
                LastMatchedKeyword = keywordResponder.LastMatchedKeyword;

                return sentiment + "\n\n" + keywordResponse;
            }

            // Special questions
            if (input.Contains("how are you"))
            {
                return "😊 I'm functioning perfectly and ready to keep you safe online!";
            }

            if (input.Contains("purpose"))
            {
                return "🎯 My purpose is to educate users about cybersecurity awareness.";
            }

            if (input.Contains("what can you do"))
            {
                return "💡 I can help with passwords, phishing, malware, scams, privacy, ransomware, VPNs, and much more!";
            }

            // Fallback response
            return fallbackResponses[random.Next(fallbackResponses.Count)];
        }
    }
}