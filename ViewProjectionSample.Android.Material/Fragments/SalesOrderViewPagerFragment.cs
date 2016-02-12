using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using Android.Views;
using System;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Android.Activities
{
    [ImportBinding(typeof(SalesOrderHeaderMultiPageBindingProvider))]
    public class SalesOrderHeaderViewPagerFragment : ViewPagerFragment<SalesOrderHeaderMultiPageViewModel>
    {
        #region Constructors

        public SalesOrderHeaderViewPagerFragment()
            : base()
        {
        }

        public SalesOrderHeaderViewPagerFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion
    }
}