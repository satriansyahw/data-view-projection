using Intersoft.Crosslight;

namespace ViewProjectionSample.BindingProviders
{
    public class SalesOrderHeaderListBindingProvider : BindingProvider
    {
        #region Constructors

        public SalesOrderHeaderListBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription
            {
                DisplayMemberPath = "SalesOrderNumber",
                DetailMemberPath = "ShipAddress",
            };

            itemBinding.AddBinding("OrderNumberLabel", BindableProperties.TextProperty, "SalesOrderNumber");
            itemBinding.AddBinding("CustomerCompanyLabel", BindableProperties.TextProperty, "CustomerCompany");
            itemBinding.AddBinding("ShippingAddressLabel", BindableProperties.TextProperty, "ShipAddress");

            itemBinding.AddBinding("DaysLeftLabel", BindableProperties.TextProperty, new BindingDescription(".") { Converter = new DayLeftLabelConverter() });
            itemBinding.AddBinding("DaysLeftLabel", BindableProperties.StyleAttributesProperty, new BindingDescription("Status") { Converter = new StatusStyleConverter() });
            
            itemBinding.AddBinding("StatusIcon", BindableProperties.IsVisibleProperty, new BindingDescription("Status") { Converter = new StatusIconVisibilityConverter() });
            itemBinding.AddBinding("StatusIcon", BindableProperties.ImageProperty, new BindingDescription("Status") { Converter = new StatusIconConverter() });
            itemBinding.AddBinding("StatusLabel", BindableProperties.TextProperty, new BindingDescription("Status") { Converter = new StatusLabelConverter() });
            
            itemBinding.AddBinding("ItemQuantityLabel", BindableProperties.TextProperty, new BindingDescription("ProductQuantity") { Converter = new ItemQuantityConverter() });
            itemBinding.AddBinding("TotalLabel", BindableProperties.TextProperty, new BindingDescription("TotalDue") { StringFormat = "{0:c2}" });

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
            this.AddBinding("TableView", BindableProperties.IsBatchUpdatingProperty, "IsBatchUpdating");
            this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.SelectedItemsProperty, "SelectedItems", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.SelectedCommandProperty, "SelectedCommand", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.IsEditingProperty, "IsEditing", BindingMode.TwoWay);
            
            this.AddBinding("RefreshButton", BindableProperties.RefreshCommandProperty, "RefreshCommand");
        }

        #endregion
    }
}