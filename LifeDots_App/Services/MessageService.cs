using LifeDots_App.Interfaces;

namespace LifeDots_App.Services
{
    public class MessageService : IMessageService
    {
        private readonly IDictionary<string, string> _messages;

        // Constructor that initializes messages from a dictionary, simulating a future JSON load.
        public MessageService()
        {
            _messages = new Dictionary<string, string>
            {
                { "MainMessageTemplate", "If you lived {0} years, you would then have {1} weeks left. Let's represent each week with a dot:" },
                { "SecondaryMessage", "Here are your life dots. Surprised to see so few? Then make good use of them!" }
            };
        }

        // Generates the main message based on years to die and weeks to die.
        public string GenerateMainMessage(int yearsToDie, int weeksToDie)
        {
            string template = _messages["MainMessageTemplate"];
            return string.Format(template, yearsToDie, weeksToDie);
        }

        // Returns the secondary message.
        public string GenerateSecondaryMessage()
        {
            return _messages["SecondaryMessage"];
        }

        // Determines whether messages should be displayed based on the years left.
        public bool ShouldDisplayMessages(int yearsToDie)
        {
            return yearsToDie > 0;
        }

        // Clears the messages by setting them to empty strings.
        public void ClearMessages(out string message, out string secondMessage)
        {
            message = string.Empty;
            secondMessage = string.Empty;
        }

        // Updates both messages by generating them based on the current data.
        public void UpdateMessages(int yearsToDie, int weeksToDie, out string message, out string secondMessage)
        {
            message = GenerateMainMessage(yearsToDie, weeksToDie);
            secondMessage = GenerateSecondaryMessage();
        }
    }
}
