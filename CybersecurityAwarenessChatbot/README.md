ure# Part 1: Cybersecurity Awareness Chatbot 

## Overview
The **Cybersecurity Awareness Chatbot** is a C# console application developed using **.NET 8**.  
The purpose of this chatbot is to educate users about common cybersecurity threats such as phishing attacks, weak passwords, and unsafe browsing practices.

The chatbot interacts with users through a simple conversational interface and provides guidance on how to stay safe online. This project forms part of a **Programming Portfolio of Evidence (POE)** and demonstrates concepts such as user input, string manipulation, console UI design, and structured programming.

---

## Objectives
The main objectives of this project are to:

- Develop a **console application that interacts with users**
- Implement **string manipulation for chatbot responses**
- Use **automatic properties in C#**
- Improve console applications using **ASCII art and colour formatting**
- Implement **voice greeting functionality**
- Practice **GitHub version control and Continuous Integration**

---

## Features

### 1. Voice Greeting
When the chatbot launches, it plays a **voice greeting (WAV file)** to welcome the user.

```
hello.wav is inside the folder audio and is played using the System.Media.SoundPlayer class in C#.
```
Example greeting:
```
Hello! Welcome to the SecureWin.
I'm here to help you stay safe online.
```

---

### 2. ASCII Art Logo
The chatbot displays an **ASCII cybersecurity-themed logo** when the program starts.

This improves the visual appearance of the console interface.

---

### 3. Personalised User Interaction
The chatbot asks the user for their name and uses it to personalise responses.

Example:

```
Please enter your name: Erwin

Hello Erwin!
Welcome to the Cybersecurity Awareness Bot.
```

---

### 4. Cybersecurity Chatbot Responses
The chatbot can answer basic cybersecurity questions including:

- How are you?
- What is your purpose?
- What can I ask you about?
- Password safety
- Phishing attacks
- Safe browsing

Example interaction:

```
You: What is phishing?

Bot: Phishing is when attackers trick you into revealing personal
information through fake emails or websites.
```

---

### 5. Input Validation
The chatbot detects invalid input such as:

- Empty messages
- Unsupported questions

Example:

```
Bot: I didn’t quite understand that. Could you rephrase?
```

---

### 6. Enhanced Console User Interface
The application uses:

- Console colours
- Decorative borders
- ASCII art
- Structured text layout

This improves readability and user experience.

---

## Technologies Used

- **C#**
- **.NET 8 Console Application**
- **System.Media (SoundPlayer)**
- **GitHub**
- **GitHub Actions (CI)**

---

## Project Structure

```
CyberSecurityAwarenessBot
│
├── Program.cs
│
├── Classes
│   ├── ChatBot.cs
│   ├── Responses.cs
│   ├── VoicePlayer.cs
│   └── UIHelper.cs
│
├── Audio
│   └── hello.wav
│
└── README.md
```

### File Descriptions

| File | Description |
|-----|-------------|
| Program.cs | Entry point of the application |
| ChatBot.cs | Handles user interaction and chatbot logic |
| Responses.cs | Contains chatbot responses to user questions |
| VoicePlayer.cs | Plays the welcome voice message |
| UIHelper.cs | Displays ASCII art and console UI formatting |
| hello.wav | Audio greeting file |

---

## How to Run the Project

### Requirements
- Visual Studio 2022 or later
- .NET 8 SDK installed

---

### Steps to Run

1. Clone the repository

```
clone https://github.com/ST10073464/CybersecurityAwarenessChatbot
```

2. Open the project in **Visual Studio**

3. Build the project

```
Build → Build Solution
```

4. Run the program

```
Ctrl + F5
```

---

## Example Output

```
========================================
      CYBERSECURITY AWARENESS BOT
========================================

Please enter your name: Erwin

Hello Erwin!
Welcome to the Cybersecurity Awareness Bot.

You: What is phishing?

Bot: Phishing is when attackers trick you into revealing personal
information through fake emails or websites.
```

---
<img width="1900" height="705" alt="image" src="https://github.com/user-attachments/assets/c8c69294-d60b-43ed-8a71-86bfbf5dadac" />


## Future Improvements

Cybersecurity Awareness Chatbot – Part 2

### Overview

The Cybersecurity Awareness Chatbot – Part 2 is an upgraded version of the Part 1 console application.
In this phase, the chatbot has been converted into a Windows Presentation Foundation (WPF) desktop application using C# and .NET 8.

The application now features a modern graphical user interface (GUI), enhanced chatbot intelligence, keyword recognition, sentiment detection, and user memory functionality. The chatbot continues to educate users about cybersecurity threats and safe online practices while providing a more interactive and engaging user experience.

This project forms part of a Programming Portfolio of Evidence (POE) and demonstrates object-oriented programming, WPF GUI development, event-driven programming, GitHub Actions CI, and modular software design.

### Objectives

## The objectives of Part 2 are to:

- Convert the chatbot from a console application to a WPF GUI application
- Implement a modern chatbot user interface
- Improve chatbot intelligence using:
- Keyword recognition
- Sentiment detection
- Memory storage
- Use object-oriented programming principles
- Practice modular class design
- Continue using GitHub version control and Continuous Integration

---

### Features

1. WPF Graphical User Interface (GUI)

The chatbot now uses a modern WPF interface instead of the console.

The interface includes:

- Chat display window
- User input text box
- Send button
- Dark cybersecurity theme- Scrollable conversation area

---

### 2. Voice Greeting
When the chatbot launches, it plays a **voice greeting (WAV file)** to welcome the user.

```
hello.wav is inside the folder audio and is played using the System.Media.SoundPlayer class in C#.
```

The chatbot plays sound effects to improve user interaction and make responses more engaging.

---

### 3. ASCII Art Logo
The chatbot displays an **ASCII cybersecurity-themed logo** when the program starts.

This improves the visual appearance of the console interface.


### 4. Intelligent Chatbot Responses

The chatbot can recognise cybersecurity-related topics and respond with helpful advice.

Supported topics include:

- Password safety
- Phishing attacks
- VPN security
- Malware protection
- Safe browsing

## Example:

You: Tell me about phishing

Bot: 🎣 Phishing is a cyberattack where attackers trick users into revealing personal information through fake emails or websites.

### 5. Sentiment Detection

The chatbot can detect emotional words in user messages and respond empathetically.

## Example:

You: I am worried about hackers

Bot: 💙 I understand your concern. Using strong passwords and enabling two-factor authentication can improve your security.

### 6. User Memory Functionality

The chatbot remembers user information such as:

User name
Favourite cybersecurity topic

## Example:

You: My name is Erwin

Bot: 👋 Nice to meet you Erwin!

### 7. Improved User Experience

### The application includes:

- Emoji-enhanced responses
- Better message formatting
- Structured conversation layout
- Enter-key support for sending messages
- Responsive chat display

### 8. Input Validation

### The chatbot handles:

Empty messages
Unsupported topics
Invalid input

## Example:

Bot: 🤔 I am still learning about that topic.
```
Technologies Used
- C#
- .NET 10.0
- WPF (Windows Presentation Foundation)
- XAML
- GitHub
- GitHub Actions (CI)
- 
### Project Structure

```
CybersecurityAwarenessChatbot/
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
│
├── classes/
├── ChatBot.cs
├── KeywordResponder.cs
├── SentimentDetector.cs
├── MemoryStore.cs
├── UIHelper.cs
├── VoicePlayer.cs
│
├── Assets/
│   └── hello.wav
│   └── notification.wav
├── images/
│   └── chatwindow.png
├── instructions/
│   └── How to Clone Part 2_ST10073464.pdf
│
├── .github/
│   └── workflows/
│       └── build.yml
│
└── README.md
```
### File Descriptions

|File	|Description|
|-----|-------------|
| MainWindow.xaml | Defines the WPF graphical user interface |
| MainWindow.xaml.cs | Handles button events and chatbot interaction |
| VoicePlayer.cs | Plays the welcome voice message |
| UIHelper.cs | Displays ASCII art and console UI formatting |
| hello.wav | Audio greeting file |
| notification.wav | message alert file |
| ChatBot.cs | Core chatbot logic and response routing |
| KeywordResponder.cs | Stores cybersecurity keywords and responses |
| SentimentDetector.cs | Detects emotional keywords in user messages |
| MemoryStore.cs	| Stores user information and preferences |
| build.yml | GitHub Actions Continuous Integration workflow |

### How to Run the Project

### Requirements

-Visual Studio 2022 or later
-.NET 8 SDK installed
- Windows operating system

## Steps to Run
---
1. Clone the Repository
clone https://github.com/ST10073464/CybersecurityAwarenessChatbot_Part_2
---
3. Open the Solution

Open the project in:
---
Visual Studio 2022 or 2026
---
## screenshot of the WPF Chatbot Interface

![CybersecurityAwarenessChatbot] (images/chatwindow.png)

## Document of how to Clone the Repository and Run the WPF Application

![CybersecurityAwarenessChatbot] (instructions/How to Clone Part 2_ST10073464.pdf)

## video demonstration of how to clone from github and run the WPF application

[CybersecurityAwarenessChatbot] (instructions/How to Clone Part 2_ST10073464.pdf)

3. Build the Solution

- Build → Build Solution

4. Run the Application

F5 or Ctrl/fn + F5


### Part 3

- Add **interactive cybersecurity activities**
- Create a **cybersecurity tips task list**
- Add **simple games for user engagement**

---

## Author

**Name:** Erwin Mashobane  
**Student number:** ST10073464 
**Module:** PROG6221/w  
**Project:** Cybersecurity Awareness Chatbot  

---

## License

This project was developed for **educational purposes** as part of a university assignment.