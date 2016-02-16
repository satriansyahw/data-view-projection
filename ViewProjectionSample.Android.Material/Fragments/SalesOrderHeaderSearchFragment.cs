using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using System;
using Android.App;
using Android.Runtime;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Android.Activities
{
    [Activity(Theme = "@style/Crosslight.Material.SearchActivity")]
    [RegisterNavigation("SalesOrderHeaderSearch")]
    [ImportBinding(typeof(SalesOrderHeaderListBindingProvider))]
    public class SalesOrderHeaderSearchActivity : SearchActivity<SalesOrderHeaderListViewModel>
    {
        #region Constructors

        public SalesOrderHeaderSearchActivity()
            : base()
        {
        }

        public SalesOrderHeaderSearchActivity(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();
        }

        #endregion
    }
}