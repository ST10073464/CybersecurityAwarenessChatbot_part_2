/*
    Erwin Mashobane
    ST10073464
*/

namespace CybersecurityAwarenessChatbot.Classes
{
    // Possible user emotions.
    public enum Sentiment
    {
        Neutral,
        Worried,
        Curious,
        Frustrated,
        Happy,
        Angry
    }

    // Detects user sentiment and returns empathetic responses.
    public class SentimentDetector
    {
        private readonly Dictionary<Sentiment, List<string>> triggerWords;
        private readonly Dictionary<Sentiment, List<string>> sentimentResponses;
        private readonly Random random;

        public SentimentDetector()
        {
            random = new Random();

            triggerWords = new Dictionary<Sentiment, List<string>>
            {
                { Sentiment.Worried, new List<string> { "worried", "scared", "afraid", "unsafe" } },
                { Sentiment.Curious, new List<string> { "curious", "interested", "wondering" } },
                { Sentiment.Frustrated, new List<string> { "frustrated", "confused", "annoyed" } },
                { Sentiment.Happy, new List<string> { "great", "awesome", "thanks" } },
                { Sentiment.Angry, new List<string> { "angry", "mad", "upset" } }
            };

            sentimentResponses = new Dictionary<Sentiment, List<string>>
            {
                {
                    Sentiment.Worried,
                    new List<string>
                    {
                        "😟 It's understandable to feel worried about online threats.",
                        "⚠️ Cybersecurity can feel overwhelming, but staying informed helps.",
                        "🤔 You're not alone — many people worry about scams online.",
                    }
                },

                {
                    Sentiment.Curious,
                    new List<string>
                    {
                        "😟 That's great curiosity helps improve cybersecurity awareness.",
                        "⚠️ Learning about online safety is a smart step.",
                        "⚠️ Cybersecurity knowledge is very valuable today."
                    }
                },

                {
                    Sentiment.Frustrated,
                    new List<string>
                    {
                        "🤔 I understand this topic can feel frustrating.",
                        "⚠️ Cybersecurity can be confusing at first.",
                        "😟 Don't worry — I'll explain it clearly."
                    }
                },

                {
                    Sentiment.Happy,
                    new List<string>
                    {
                        "🤔 I'm glad you're enjoying learning about cybersecurity.",
                        "😊 That's great to hear.",
                        "😟 Awesome — let's continue improving your online safety."
                    }
                },

                {
                    Sentiment.Angry,
                    new List<string>
                    {
                        "😟 I understand your frustration.",
                        "😤 Online threats can be very upsetting.",
                        "🤔 Let's work through this together calmly."
                    }
                }
            };
        }

        // Detects the user's sentiment.
        public Sentiment Detect(string input)
        {
            input = input.ToLower();

            foreach (var sentiment in triggerWords)
            {
                foreach (string word in sentiment.Value)
                {
                    if (input.Contains(word))
                    {
                        return sentiment.Key;
                    }
                }
            }

            return Sentiment.Neutral;
        }

        // Returns empathetic response.
        public string GetSentimentResponse(Sentiment sentiment)
        {
            if (sentiment == Sentiment.Neutral)
                return "";

            List<string> responses = sentimentResponses[sentiment];

            return responses[random.Next(responses.Count)];
        }
    }
}

