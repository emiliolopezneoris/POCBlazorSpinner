using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace RazorClassLibrary.Services
{
	public class SpinnerService : ISpinnerService
	{
		private readonly ILogger<SpinnerService> logger;

		public Guid Guid { get; }

		public event Func<Task> OnShow;
		public event Func<Task> OnHide;

		public SpinnerService(ILogger<SpinnerService> logger)
		{
			Guid = Guid.NewGuid();
			this.logger = logger;
			this.logger.LogInformation($"Initializing SpinnerService: {Guid}");
		}

		public async Task Show()
		{
			OnShow?.Invoke();
		}

		public async Task Hide()
		{
			OnHide?.Invoke();
		}
	}
}
