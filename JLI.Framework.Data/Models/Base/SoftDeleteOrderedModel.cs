namespace JLI.Framework.Data.Models {

    public abstract class SoftDeleteOrderedModel : SoftDeleteModel, IOrderedModel {

        public int Order { get; set; }

    }
}
