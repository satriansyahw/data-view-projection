using Intersoft.Crosslight;

namespace ViewProjectionSample.BindingProviders
{
    public class SalesOrderHeaderMultiPageBindingProvider : BindingProvider
    {
        #region Constructors

        public SalesOrderHeaderMultiPageBindingProvider()
        {
            this.AddBinding("SearchButton", BindableProperties.CommandProperty, "SearchCommand");
        }

        #endregion
    }
}