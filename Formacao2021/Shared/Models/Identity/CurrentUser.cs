using System.Collections.Generic;

namespace Formacao2021.Shared.Models.Identity
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }

        public string UserName { get; set; }

        public Dictionary<string, string> Claims { get; set; }
    }
}
