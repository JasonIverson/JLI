namespace JLI.Framework.Data.Models {

    public interface ISoftDeleteModel {

        public DateTime? DeletedDateUtc { get; set; }

        bool IsDeleted { get; }

        void Delete();

    }

}
