namespace WebApp.Models.Profiles {

    public interface IProfileChild {

        Guid ProfileId { get; set; }

        public Profile? Profile { get; set; }

    }

}
