using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7;
using System;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Android.Activities
{
    [ImportBinding(typeof(SalesOrderHeaderListBindingProvider))]
    public class SalesOrderHeaderListFragment : RecyclerViewFragment<SalesOrderHeaderListViewModel>
    {
        #region Constructors

        public SalesOrderHeaderListFragment()
            : base()
        {
        }

        public SalesOrderHeaderListFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ItemLayoutId
        {
            get
            {
                return Resource.Layout.order_list_item_layout;
            }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();
            
            this.IconId = Resource.Drawable.ic_toolbar;
            this.InteractionMode = ListViewInteraction.Navigation;
        }

        #endregion
    }
}