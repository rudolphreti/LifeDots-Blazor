using LifeDots_App.Interfaces;
using Microsoft.AspNetCore.Components;

namespace LifeDots_App.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject] private IHomeService HomeServiceInstance { get; set; } = default!;

        protected override void OnInitialized()
        {
            HomeServiceInstance.OnChange = StateHasChanged;
        }


        private void Increment() => HomeServiceInstance.IncrementYears();
        private void Decrement() => HomeServiceInstance.DecrementYears();
        private void UpdateDisplay() => HomeServiceInstance.UpdateDisplay();
    }
}
