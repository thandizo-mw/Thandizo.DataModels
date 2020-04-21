using Thandizo.DataModels.Identity.DataTransfer;

namespace Thandizo.DataModels.Identity.ViewModelss
{
    public class LogoutViewModel : LogoutDTO
    {
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}
