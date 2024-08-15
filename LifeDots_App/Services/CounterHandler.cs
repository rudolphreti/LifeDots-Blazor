using LifeDots_App.Interfaces;

namespace LifeDots_App.Services
{
    public class CounterHandler : ICounterHandler
    {
        private int _yearsToDie;

        public int YearsToDie
        {
            get => _yearsToDie;
            set
            {
                if (_yearsToDie != value && value >= 0)
                {
                    _yearsToDie = value;
                }
            }
        }

        public int WeeksToDie => YearsToDie * 52;

        public void Increment() => YearsToDie++;

        public void Decrement()
        {
            if (YearsToDie > 0) YearsToDie--;
        }
    }
}
