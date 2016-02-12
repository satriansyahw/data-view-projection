using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Android.Activities
{
    [RegisterNavigation("SalesOrderHeaderSearch")]
    [ImportBinding(typeof(SalesOrderHeaderListBindingProvider))]
    public class SalesOrderHeaderSearchFragment : SearchableRecyclerViewFragment<SalesOrderHeaderListViewModel>
    {
        #region Properties
        
        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.Standard;
            }
        }

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

            this.InteractionMode = ListViewInteraction.Standard;
            this.AddBarItem(new BarItem("SearchButton", CommandItemType.Search));
            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}