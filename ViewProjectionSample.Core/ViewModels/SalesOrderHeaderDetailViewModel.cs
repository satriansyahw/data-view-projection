using System;
using System.Threading.Tasks;
using Intersoft.AppFramework.ViewModels;
using Intersoft.Crosslight;
using ViewProjectionSample.DomainModels;
using ViewProjectionSample.Models;

namespace ViewProjectionSample.ViewModels
{
    public class SalesOrderHeaderDetailViewModel : DataEditorViewModelBase<SalesOrderHeader, ISalesOrderHeaderRepository>
    {
        #region Constructors

        public SalesOrderHeaderDetailViewModel()
        {
            this.Title = "Sales Order Header";
        }

        #endregion

        #region Properties

        public override Type FormMetadataType
        {
            get
            {
                return typeof(SalesOrderDetailForm);
            }
        }

        #endregion

        #region Methods

        public async override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            if (parameter.Data != null)
            {
                // only load additional data if it hasn't been loaded previously
                if (this.Item.Customer == null)
                {
                    this.ActivityPresenter.Show("Loading");
                    this.IsDataLoading = true;

                    // reload item along with the specified navigation properties
                    await this.Repository.GetSingleAsync((parameter.Data as SalesOrderHeader).SalesOrderID, new string[] { "Customer", "Address1", "SalesOrderDetails", "SalesOrderDetails.Product" });

                    this.IsDataLoading = false;
                    this.ActivityPresenter.Hide();
                }
            }
        }

        #endregion
    }
}