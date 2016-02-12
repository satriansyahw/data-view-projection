using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using System;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;

namespace ViewProjectionSample.Android.Activities
{
    [ImportBinding(typeof(AboutBindingProvider))]
    public class AboutFragment : Fragment<AboutViewModel>
    {
        #region Constructors

        public AboutFragment()
            : base()
        {
        }

        public AboutFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get
            {
                return Resource.Layout.about_layout;
            }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
            this.Appearance.Padding = new Thickness(16);
        }

        #endregion
    }
}