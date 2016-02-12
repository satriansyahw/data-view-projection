using System;
using System.Drawing;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.iOS
{
    [Register("AboutViewController")]
    [ImportBinding(typeof(AboutBindingProvider))]
    public partial class AboutViewController : UIViewController<AboutViewModel>
    {
        public AboutViewController()
            : base("AboutView", null)
        {
        }
    }
}

