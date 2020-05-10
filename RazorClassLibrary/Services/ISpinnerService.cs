using System;
using System.Threading.Tasks;

namespace RazorClassLibrary.Services
{
    public interface ISpinnerService
    {
        event Func<Task> OnHide;
        event Func<Task> OnShow;

        Task Hide();
        Task Show();
    }
}