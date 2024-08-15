using LifeDots_App.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Services
{
    public class HomeService(ICounterHandler counterHandler, IDotGenerator dotGenerator, IMessageService messageGenerator) : IHomeService
    {
        private readonly ICounterHandler _counterHandler = counterHandler;
        private readonly IDotGenerator _dotGenerator = dotGenerator;
        private readonly IMessageService _messageService = messageGenerator;

        public Action OnChange { get; set; } = () => { };

        public int YearsToDie
        {
            get => _counterHandler.YearsToDie;
            set
            {
                if (_counterHandler.YearsToDie != value)
                {
                    _counterHandler.YearsToDie = value;
                    UpdateDisplay();
                }
            }
        }


        public string Message { get; private set; } = string.Empty;
        public MarkupString DotsDisplay { get; private set; }
        public string SecondMessage { get; private set; } = string.Empty;

        public void IncrementYears()
        {
            _counterHandler.Increment();
            UpdateDisplay();
        }

        public void DecrementYears()
        {
            _counterHandler.Decrement();
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            if (_messageService.ShouldDisplayMessages(_counterHandler.YearsToDie))
            {
                _messageService.UpdateMessages(_counterHandler.YearsToDie, _counterHandler.WeeksToDie, out string message, out string secondMessage);
                Message = message;
                SecondMessage = secondMessage;

                DotsDisplay = _dotGenerator.UpdateDotsDisplay(_counterHandler.WeeksToDie);
            }
            else
            {
                _messageService.ClearMessages(out string message, out string secondMessage);
                Message = message;
                SecondMessage = secondMessage;
                DotsDisplay = new MarkupString(string.Empty);
            }

            OnChange?.Invoke();
        }
    }
}