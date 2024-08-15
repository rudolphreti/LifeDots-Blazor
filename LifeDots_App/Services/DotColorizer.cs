using LifeDots_App.Interfaces;
using System.Text;
using System.Text.RegularExpressions;

namespace LifeDots_App.Services
{
    public class DotColorizer : IDotColorizer
    {
        public string ColorDots(string dotsHtml)
        {
            int counter = 0;
            var array = new StringBuilder();
            MatchCollection matches = Regex.Matches(dotsHtml, @"\.");

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
