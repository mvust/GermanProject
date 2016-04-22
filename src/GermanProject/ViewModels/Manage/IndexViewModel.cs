using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace GermanProject.ViewModels.Manage
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}