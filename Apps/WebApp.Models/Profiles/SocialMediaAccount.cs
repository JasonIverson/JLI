using JLI.Framework.Data.Models;

namespace WebApp.Models.Profiles {

    public class SocialMediaAccount : OrderedModel, IProfileChild {

        public Guid ProfileId { get; set; }

        public Profile? Profile { get; set; }

        public SocialMediaPlatforms Platform { get; set; }

        public String UserName { get; set; } = null!;

    }

}
