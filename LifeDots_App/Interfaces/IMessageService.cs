namespace LifeDots_App.Interfaces
{
    public interface IMessageService
    {
        string GenerateMainMessage(int yearsToDie, int weeksToDie);
        string GenerateSecondaryMessage();
        bool ShouldDisplayMessages(int yearsToDie);
        void ClearMessages(out string message, out string secondMessage);
        void UpdateMessages(int yearsToDie, int weeksToDie, out string message, out string secondMessage);
    }
}
