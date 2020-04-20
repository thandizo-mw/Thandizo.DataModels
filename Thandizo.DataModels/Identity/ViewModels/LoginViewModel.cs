using System.Collections.Generic;
using Thandizo.DataModels.Identity.DataTransfer;

namespace Thandizo.DataModels.Identity.ViewModels
{
    public class LoginViewModel : LoginDTO
    {
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;
    }
}