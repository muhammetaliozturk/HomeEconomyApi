using Microsoft.AspNetCore.Identity;


namespace HomeEconomyApi.Core.Entities.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
