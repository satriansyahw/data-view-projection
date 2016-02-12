using AdventureWorks.ViewModels;
using Intersoft.Crosslight.iOS;
using Foundation;
using UIKit;

namespace AdventureWorks.iOS
{
    [Register("MainDrawerViewController")]
    public class MainDrawerViewController : UIDrawerNavigationController<DrawerViewModel>
    {
        #region Constructors

        public MainDrawerViewController()
        {
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlur;
            this.DrawerSettings.LeftStatusBarColor = UIColor.GroupTableViewBackgroundColor;
        }

        #endregion
    }
}