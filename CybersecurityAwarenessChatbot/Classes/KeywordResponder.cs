/*
    Erwin Mashobane
    ST10073464
*/
using System;
using System.Collections.Generic;
//using System.Data;

namespace CybersecurityAwarenessChatbot.Classes
{
    class Responses
    {
        private static Random rand = new Random();

        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            // Greeting
            if (Contains(input, "how are you", "hello", "hey", "hi"))
            {
                return RandomResponse(
                    $"Hey there How can I help you stay safe online today?",
                    $"Hi! Ready to learn how to protect yourself online?",
                    $"Hello! I'm here to help you stay secure online"
                );
            }

            // Purpose
            else if (Contains(input, "purpose", "what do you do"))
            {
                return RandomResponse(
                    "My purpose is to help you understand cybersecurity and stay safe online.",
                    "I guide you on how to avoid online threats and protect your data.",
                    "I'm here to teach you how to stay secure in the digital world."
                );
            }

            // Password Safety
            else if (Contains(input, "password"))
            {
                return RandomResponse(
                    "A strong password should include uppercase, lowercase, numbers, and symbols",
                    "Make your passwords long and unique. Avoid using personal info!",
                    "Tip: Use a mix of characters and never reuse passwords across sites."
                );
            }

            // Advanced Password
            else if (Contains(input, "strong password", "create password"))
            {
                return RandomResponse(
                    "Try a passphrase like 'BlueSky#2026!' — strong and memorable.",
                    "Use a sentence-style password, it's harder to crack.",
                    "Combine random words with symbols for better security."
                );
            }

            // Phishing
            else if (Contains(input, "phishing", "scam"))
            {
                return RandomResponse(
                    "Phishing tricks you into giving personal info through fake emails or sites.",
                    "Always double-check emails before clicking links — scammers are sneaky!",
                    "If something feels urgent or suspicious, it’s probably a scam."
                );
            }

            // Suspicious Emails
            else if (Contains(input, "suspicious email", "fake email"))
            {
                return RandomResponse(
                    "Never click unknown links. Verify emails directly with the company.",
                    "Check the sender’s address carefully — scammers fake identities.",
                    "If it asks for personal info urgently, it's likely a scam."
                );
            }

            // Browsing
            else if (Contains(input, "safe browsing", "browser", "website"))
            {
                return RandomResponse(
                    "Always look for HTTPS before entering sensitive info.",
                    "Avoid downloading from unknown websites.",
                    "Keep your browser updated for better protection."
                );
            }

            // Links
            else if (Contains(input, "link", "url"))
            {
                return RandomResponse(
                    "Hover over links to see where they really go.",
                    "Shortened links can hide dangerous sites — be careful!",
                    "If a link looks suspicious, don’t click it."
                );
            }

            // Malware
            else if (Contains(input, "malware", "virus"))
            {
                return RandomResponse(
                    "Malware can steal data or damage your system — avoid unsafe downloads.",
                    "Install antivirus software and keep it updated.",
                    "Be careful what you install — not all software is safe."
                );
            }

            // Social Engineering
            else if (Contains(input, "social engineering"))
            {
                return RandomResponse(
                    "Attackers manipulate people to get sensitive info — stay alert.",
                    "Never trust unexpected requests for personal data.",
                    "Always verify before sharing confidential information."
                );
            }

            // Personal Data
            else if (Contains(input, "personal information", "data protection"))
            {
                return RandomResponse(
                    "Never share sensitive info unless you're sure the site is secure.",
                    "Protect your identity — don’t overshare online.",
                    "Keep your personal data private and secure."
                );
            }

            // WiFi
            else if (Contains(input, "wifi", "public wifi"))
            {
                return RandomResponse(
                    "Public WiFi is risky — avoid logging into sensitive accounts.",
                    "Use a VPN when using public networks.",
                    "Hackers can intercept data on public WiFi."
                );
            }

            // 2FA
            else if (Contains(input, "2fa", "two factor"))
            {
                return RandomResponse(
                    "2FA adds an extra layer of security — always enable it!",
                    "Even if your password is stolen, 2FA keeps you safe.",
                    "It’s one of the best ways to protect your accounts."
                );
            }

            // What can I ask
            else if (Contains(input, "what can i ask"))
            {
                return RandomResponse(
                    "You can ask about passwords, scams, malware, or safe browsing.",
                    "Try asking me about online threats or how to protect yourself.",
                    "I can help with cybersecurity tips and best practices."
                );
            }

            // Default (AI-like fallback)
            else
            {
                return RandomResponse(
                    "Hmm I’m not sure I understood that. Try asking about cybersecurity topics.",
                    "Interesting… could you rephrase that in terms of online safety?",
                    "I'm still learning — try asking about passwords, scams, or browsing safety."
                );
            }
        }

        // Helper: Keyword matching
        private bool Contains(string input, params string[] keywords)
        {
            foreach (var word in keywords)
            {
                if (input.Contains(word))
                    return true;
            }
            return false;
        }

        // Helper: AI-style random responses
        private string RandomResponse(params string[] responses)
        {
            return responses[rand.Next(responses.Length)];
        }
    }
}