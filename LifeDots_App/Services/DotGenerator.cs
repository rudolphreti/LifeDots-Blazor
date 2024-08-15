using LifeDots_App.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Text;

namespace LifeDots_App.Services
{
    public class DotGenerator(IDotColorizer dotColorizer) : IDotGenerator
    {
        private readonly IDotColorizer _dotColorizer = dotColorizer;

        public string GenerateDots(int weeksToDie)
        {
            var dots = new StringBuilder();
            for (int i = 0; i < weeksToDie; i++)
            {
                dots.Append(". ");
            }

            return _dotColorizer.ColorDots(dots.ToString());
        }
        public MarkupString UpdateDotsDisplay(int weeksToDie)
        {
            return new MarkupString(GenerateDots(weeksToDie));
        }
    }
    
}
