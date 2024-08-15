using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Interfaces
{
    public interface IHomeService
    {
        int YearsToDie { get; set; }
        string Message { get; }
        MarkupString DotsDisplay { get; }
        string SecondMessage { get; }
        Action OnChange { get; set; }

        void IncrementYears();
        void DecrementYears();
        void UpdateDisplay();
    }
}
