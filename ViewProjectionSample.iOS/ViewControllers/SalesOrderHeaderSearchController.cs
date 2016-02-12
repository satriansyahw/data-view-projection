using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.iOS.ViewControllers
{
    [RegisterNavigation("SalesOrderHeaderSearch")]
    public partial class SalesOrderHeaderSearchController : UISearchController<SalesOrderHeaderListViewModel>
    {
        #region Constructors

        public SalesOrderHeaderSearchController()
        {
        }

        public override bool AutomaticallyForwardAppearanceAndRotationMethodsToChildViewControllers
        {
            get
            {
                return true;
            }
        }

        public override bool ShouldAutomaticallyForwardRotationMethods
        {
            get
            {
                return true;
            }
        }

        #endregion
    }
}