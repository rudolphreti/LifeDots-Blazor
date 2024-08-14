using Microsoft.AspNetCore.Components;
using System.Text;

namespace LifeDots_App.Pages
{
    public partial class Home
    {
        private int _yearsToDie;
        private int YearsToDie
        {
            get => _yearsToDie;
            set
            {
                if (_yearsToDie != value)
                {
                    _yearsToDie = value;
                    GenerateDots();
                }
            }
        }

        private string? Message { get; set; }
        private MarkupString DotsDisplay { get; set; }
        private string? SecondMessage { get; set; }

        private void Increment()
        {
            YearsToDie++;
        }

        private void Decrement()
        {
            if (YearsToDie > 0) YearsToDie--;
        }

        private void GenerateDots()
        {
            if (YearsToDie > 0)
            {
                int weeksToDie = YearsToDie * 52;
                var dots = new StringBuilder();
                for (int i = 0; i < weeksToDie; i++)
                {
                    dots.Append(". ");
                }

                // Zamiana string na MarkupString, aby Blazor renderował HTML
                DotsDisplay = new MarkupString(ColorDots(dots.ToString()));

                Message = $"If you lived {YearsToDie} years, you would then have {weeksToDie} weeks left. Let's represent each week with a dot:";
                SecondMessage = "Here are your life dots. Surprised to see so few? Then make good use of them!";
            }
            else
            {
                Message = null;
                DotsDisplay = new MarkupString(string.Empty);
                SecondMessage = null;
            }
        }

        private static string ColorDots(string dotsHtml)
        {
            int counter = 0;
            var array = new StringBuilder();
            var matches = System.Text.RegularExpressions.Regex.Matches(dotsHtml, @"\.");

            foreach (var match in matches)
            {
                switch (counter)
                {
                    case 0:
                        array.Append($"<span style='color: red'>{match} </span>");
                        counter = 1;
                        break;
                    case 1:
                        array.Append($"<span style='color: yellow'>{match} </span>");
                        counter = 2;
                        break;
                    case 2:
                        array.Append($"<span style='color: green'>{match} </span>");
                        counter = 3;
                        break;
                    case 3:
                        array.Append($"<span style='color: blue'>{match} </span>");
                        counter = 0;
                        break;
                }
            }

            return array.ToString();
        }
    }
}
