using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.iOS
{
    [Register("SalesOrderHeaderSegmentedBarController")]
    [ImportBinding(typeof(SalesOrderHeaderMultiPageBindingProvider))]
    public class SalesOrderHeaderSegmentedBarController : UISegmentedBarController<SalesOrderHeaderMultiPageViewModel>
    {
        public SalesOrderHeaderSegmentedBarController()
        {
        }

        public SalesOrderHeaderSegmentedBarController(SalesOrderHeaderMultiPageViewModel viewModel)
            : base(viewModel)
        {
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            UIBarButtonItem searchButton = new UIBarButtonItem(UIBarButtonSystemItem.Search);
            this.NavigationItem.SetRightBarButtonItem(searchButton, false);
            this.NavigationItem.Title = "";

            this.RegisterViewIdentifier("SearchButton", searchButton);
        }
    }
}
