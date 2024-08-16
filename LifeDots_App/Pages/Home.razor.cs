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


        public void Increment() => HomeServiceInstance.IncrementYears();
        public void Decrement() => HomeServiceInstance.DecrementYears();
        public void UpdateDisplay() => HomeServiceInstance.UpdateDisplay();
    }
}
