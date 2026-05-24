using CybersecurityAwarenessChatbot.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CybersecurityAwarenessChatbot
{
    // Main GUI window for SecureWin chatbot.
    // Handles user interaction and displays chat messages.
    public partial class MainWindow : Window
    {
        private ChatBot _chatBot;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize chatbot
            _chatBot = new ChatBot();

            // Load ASCII art
            AsciiArtText.Text = AsciiArtService.LoadAsciiArt();

            // Play greeting voice
            VoicePlayer.PlayGreeting();

            // Display greeting message
            AppendBotMessage(_chatBot.GetGreeting());
        }

        // Handles send button click.
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        // Allows Enter key to send messages.
        private void UserInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendMessage();
            }
        }

        // Sends user message to chatbot.
        private void SendMessage()
        {
            string input = UserInputTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
                return;

            // Play Notification sound
            VoicePlayer.PlaySound();

            // Display user message
            AppendUserMessage(input);

            // Process chatbot response
            string response = _chatBot.ProcessInput(input);

            // Display bot response
            AppendBotMessage(response);

            // Clear input box
            UserInputTextBox.Clear();

            // Smooth scroll
            ChatScrollViewer.ScrollToBottom();
        }

        // Displays user message bubble.
        private void AppendUserMessage(string message)
        {
            Border bubble = new Border
            {
                Background = new SolidColorBrush(Color.FromRgb(0, 194, 255)),
                CornerRadius = new CornerRadius(15),
                Padding = new Thickness(12),
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Right,
                MaxWidth = 700
            };

            TextBlock text = new TextBlock
            {
                Text = $"🧑 You [{DateTime.Now:HH:mm}]\n{message}",
                Foreground = Brushes.White,
                FontSize = 16,
                TextWrapping = TextWrapping.Wrap
            };

            bubble.Child = text;

            ChatPanel.Children.Add(bubble);
        }

        // Displays bot message bubble.
        private void AppendBotMessage(string message)
        {
            Border bubble = new Border
            {
                Background = new SolidColorBrush(Color.FromRgb(16, 38, 58)),
                CornerRadius = new CornerRadius(15),
                Padding = new Thickness(12),
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Left,
                MaxWidth = 750
            };

            TextBlock text = new TextBlock
            {
                Text = $"🤖 SecureWin [{DateTime.Now:HH:mm}]\n{message}",
                Foreground = Brushes.White,
                FontSize = 16,
                TextWrapping = TextWrapping.Wrap
            };

            bubble.Child = text;

            ChatPanel.Children.Add(bubble);
        }

        // Adds emojis to the input box.
        private void Emoji_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            UserInputTextBox.Text += " " + button.Content.ToString();
            UserInputTextBox.Focus();
            UserInputTextBox.CaretIndex = UserInputTextBox.Text.Length;
        }
    }
}