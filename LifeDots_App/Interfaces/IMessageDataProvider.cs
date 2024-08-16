namespace LifeDots_App.Interfaces
{
    public interface IMessageDataProvider
    {
        Task LoadMessages();
        string GetMainMessage(int yearsToDie, int weeksToDie); 
        string GetSecondaryMessage();
    }
}
