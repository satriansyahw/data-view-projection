using System;
using Intersoft.AppFramework;
using Intersoft.Crosslight.Data.ComponentModel;

namespace ViewProjectionSample.Models
{
    public class SalesOrderHeaderQueryDefinition : QueryDefinitionBase
    {
        #region Constructors

        public SalesOrderHeaderQueryDefinition()
        {
            this.SortExpression = "DueDate asc";
        }

        #endregion

        #region Properties

        public string ViewScope { get; set; }
       
        #endregion
        
        #region Methods

        public override QueryDescriptor GetQueryDescriptor()
        {
            QueryDescriptor queryDescriptor = this.GetBaseQueryDescriptor();
            queryDescriptor.FilterDescriptors.LogicalOperator = FilterCompositionLogicalOperator.And;
            
            switch (this.ViewScope)
            {
                case "Complete":
                    CompositeFilterDescriptor statusFilter = new CompositeFilterDescriptor();
                    statusFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
                    statusFilter.FilterDescriptors.Add(new FilterDescriptor("Status", FilterOperator.IsGreaterThanOrEqualTo, 4));
                    queryDescriptor.FilterDescriptors.Add(statusFilter);
                    break;
                case "Pending":
                    CompositeFilterDescriptor pendingFilter = new CompositeFilterDescriptor();
                    pendingFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
                    pendingFilter.FilterDescriptors.Add(new FilterDescriptor("Status", FilterOperator.IsLessThanOrEqualTo, 3));
                    queryDescriptor.FilterDescriptors.Add(pendingFilter);
                    break;
            }

            if (!string.IsNullOrWhiteSpace(this.FilterQuery))
            {
                if (!string.IsNullOrWhiteSpace(this.FilterScope))
                {
                    queryDescriptor.FilterDescriptors.Add(new FilterDescriptor(this.FilterScope, FilterOperator.StartsWith, this.FilterQuery));
                }
                else
                {
                    queryDescriptor.SortDescriptors.Clear();
                    queryDescriptor.SortDescriptors.Add(new SortDescriptor("ModifiedDate", ListSortDirection.Descending));

                    CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                    compositeFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
                    compositeFilter.FilterDescriptors.Add(new FilterDescriptor("Customer.CompanyName", FilterOperator.StartsWith, this.FilterQuery));
                    compositeFilter.FilterDescriptors.Add(new FilterDescriptor("SalesOrderNumber", FilterOperator.StartsWith, this.FilterQuery));
                    compositeFilter.FilterDescriptors.Add(new FilterDescriptor("PurchaseOrderNumber", FilterOperator.StartsWith, this.FilterQuery));

                    // Use AnyFilterDescriptor to filter Items with one of its navigation properties that satisfy the given filter.
                    AnyFilterDescriptor productFilter = new AnyFilterDescriptor("SalesOrderDetails");
                    productFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
                    productFilter.FilterDescriptors.Add(new FilterDescriptor("Product.Name", FilterOperator.StartsWith, this.FilterQuery));
                    productFilter.FilterDescriptors.Add(new FilterDescriptor("Product.ProductNumber", FilterOperator.StartsWith, this.FilterQuery));
                    compositeFilter.FilterDescriptors.Add(productFilter);

                    queryDescriptor.FilterDescriptors.Add(compositeFilter);
                }
            }

            return queryDescriptor;
        }

        #endregion
    }
}