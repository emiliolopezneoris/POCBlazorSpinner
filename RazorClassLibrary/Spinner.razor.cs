using Microsoft.AspNetCore.Components;
using RazorClassLibrary.Services;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    public partial class Spinner
    {
        [Inject]
        protected ISpinnerService SpinnerService { get; set; }
        protected bool IsVisible { get; set; }
        protected override void OnInitialized()
        {
            SpinnerService.OnShow += ShowSpinner;
            SpinnerService.OnHide += HideSpinner;
        }

        public async Task ShowSpinner()
        {
            await InvokeAsync(() => {
                IsVisible = true;
                StateHasChanged();
            });
        }

        public async Task HideSpinner()
        {
            await InvokeAsync(() => {
                IsVisible = false;
                StateHasChanged();
            });
        }
    }
}
