using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace Scoped.Pages
{
    public partial class Index
    {
        [Inject]
        protected IHttpClientFactory Client { get; set; }

        protected async Task HttpCall() {
            await Client.CreateClient("x").GetStringAsync("https://www.google.com/");
        }
    }
}
