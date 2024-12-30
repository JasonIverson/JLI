namespace JLI.Framework.Data.Models {

    public abstract class OrderedModel : Model, IOrderedModel {

        public int Order { get; set; }

    }
}
