namespace JLI.Framework.Data.Models {

    public abstract class SoftDeleteModel : Model, ISoftDeleteModel {

        public DateTime? DeletedDateUtc { get; set; }

        public bool IsDeleted => this.DeletedDateUtc.HasValue;

        public virtual void Delete() {
            if (!this.IsDeleted)
                this.DeletedDateUtc = DateTime.UtcNow;
        }

    }

}
