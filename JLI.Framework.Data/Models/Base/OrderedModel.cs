namespace JLI.Framework.Data.Models {

    public abstract class OrderedModel : ModelBase, IOrderedModel {

        public int Order { get; set; }

    }
}
