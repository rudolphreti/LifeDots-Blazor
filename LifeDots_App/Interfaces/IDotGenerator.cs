using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Interfaces
{
    public interface IDotGenerator
    {
        string GenerateDots(int weeksToDie);
        MarkupString UpdateDotsDisplay(int weeksToDie);
    }
}
