using LifeDots_App.Interfaces;

namespace LifeDots_App.Services
{
    public class MessageService : IMessageService
    {
        public string GenerateMainMessage(int yearsToDie, int weeksToDie)
        {
            return $"If you lived {yearsToDie} years, you would then have {weeksToDie} weeks left. Let's represent each week with a dot:";
        }

        public string GenerateSecondaryMessage()
        {
            return "Here are your life dots. Surprised to see so few? Then make good use of them!";
        }

        public bool ShouldDisplayMessages(int yearsToDie)
        {
            return yearsToDie > 0;
        }
        public void ClearMessages(out string message, out string secondMessage)
        {
            message = string.Empty;
            secondMessage = string.Empty;
        }

        public void UpdateMessages(int yearsToDie, int weeksToDie, out string message, out string secondMessage)
        {
            message = GenerateMainMessage(yearsToDie, weeksToDie);
            secondMessage = GenerateSecondaryMessage();
        }
    }
}
