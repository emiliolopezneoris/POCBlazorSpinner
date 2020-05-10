using RazorClassLibrary.Services;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class BlazorDisplaySpinnerAutomaticallyHttpMessageHandler : DelegatingHandler
    {
        private readonly ISpinnerService _spinnerService;
        public BlazorDisplaySpinnerAutomaticallyHttpMessageHandler(ISpinnerService spinnerService)
        {
            _spinnerService = spinnerService;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _spinnerService.Show();
            var response = await base.SendAsync(request, cancellationToken);
            await Task.Delay(2000);
            _spinnerService.Hide();
            return response;
        }
    }
}
