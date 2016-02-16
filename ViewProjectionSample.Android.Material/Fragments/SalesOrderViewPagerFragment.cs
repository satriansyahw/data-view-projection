using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
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

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.AddBarItem(new BarItem("SearchButton", CommandItemType.Search));
        }

        #endregion
    }
}