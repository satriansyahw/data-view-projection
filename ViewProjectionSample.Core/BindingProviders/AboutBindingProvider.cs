using Intersoft.Crosslight;

namespace ViewProjectionSample.BindingProviders
{
    public class AboutBindingProvider : BindingProvider
    {
        #region Constructors
        public AboutBindingProvider()
        {
            this.AddBinding("DescriptionLabel", BindableProperties.TextProperty, "Description");
            this.AddBinding("LearnMoreButton", BindableProperties.CommandProperty, "LearnMoreCommand");
        }
        #endregion
    }
}