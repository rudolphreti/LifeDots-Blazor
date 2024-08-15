namespace LifeDots_App.Interfaces
{
    public interface ICounterHandler
    {
        int YearsToDie { get; set; }
        int WeeksToDie { get; }
        void Increment();
        void Decrement();
    }
}
