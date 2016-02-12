using System.Drawing;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.iOS
{
    [Register("SalesOrderHeaderDetailViewController")]
    public class SalesOrderHeaderDetailViewController : UIFormViewController<SalesOrderHeaderDetailViewModel>
    {
        #region Constructors

        public SalesOrderHeaderDetailViewController()
        {
            // Uncomment for iOS6
            // this.ContentSizeForViewInPopover = new SizeF(350f, 550f);

            this.PreferredContentSize = new SizeF(350f, 550f);
        }

        #endregion

        #region Methods

        public override void DetermineNavigationMode(NavigationParameter parameter)
        {
            if (this.GetService<IApplicationService>().GetContext().Device.Kind == DeviceKind.Tablet)
            {
                // Only customize the navigation mode for editing (default navigation command)
                if (parameter.CommandId == null)
                {
                    parameter.PreferPopover = true;
                    parameter.EnsureNavigationContext = true;
                }
            }
        }

        #endregion
    }
}
