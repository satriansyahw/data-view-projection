using System;
using System.Collections;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Forms;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Models
{
    [Form(Title = "Sales Order Detail")]
    public class SalesOrderDetailForm
    {
        [Section("Due Date")]
        public static DueDateSection DueDate;

        [Section("Shipping Address")]
        public static AddressSection Address;

        [Section("Customer")]
        public static CustomerSection CustomerDetail;

        [Section("Order Details")]
        public static OrderDetailSection OrderDetail;

        [Section("Total Due Amount")]
        public static TotalSection Total;

        [Section("Order Information")]
        public static GeneralSection General;

        [Section("Order Comment")]
        public static CommentSection Comment;

        public class DueDateSection
        {
            [Editor(EditorType.AutoDetect)]
            [StringInput(Placeholder = "Due Date")]
            [Binding(Path = "DueDate", StringFormat = "{0:MMM dd, yyyy}")]
            [Display(Caption = "Due Date")]
            public static DateTime DueDate;
        }

        public class AddressSection
        {
            [Editor(EditorType.AutoDetect)]
            [StringInput(Placeholder = "Ship Address Line")]
            [Binding(Path = "Address1.AddressLine1")]
            [Display(Caption = "Address")]
            public string ShipAddress;

            [Editor(EditorType.AutoDetect)]
            [StringInput(Placeholder = "Ship City")]
            [Binding(Path = "Address1.City")]
            [Display(Caption = "City", MaxNumberOfLines = 3)]
            public string ShipCity;

            [Editor(EditorType.AutoDetect)]
            [StringInput(Placeholder = "Ship Province")]
            [Binding(Path = "Address1.StateProvince")]
            [Display(Caption = "Province", MaxNumberOfLines = 3)]
            public string ShipStateProvince;
        }

        public class CustomerSection
        {
            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Company")]
            [Binding(Path = "Customer.CompanyName")]
            [Display(Caption = "Company")]
            public static string CompanyName;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Name")]
            [Binding(Path = "Customer.FullName")]
            [Display(Caption = "Name")]
            public static string FullName;
        }

        public class OrderDetailSection
        {
            [Editor(EditorType.ListView)]
            [ListView(DisplayMemberPath = "Product.Name", DetailMemberPath = "SummaryInfo", Style = ListViewCellStyle.Subtitle)]
            public IEnumerable SalesOrderDetails;
        }

        public class TotalSection
        {
            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Sub Total")]
            [Display(Caption = "Sub Total")]
            [Binding(Path = "SubTotal", StringFormat = "{0:c2}")]
            public double SubTotal;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Freight")]
            [Display(Caption = "Freight")]
            [Binding(Path = "Freight", StringFormat = "{0:c2}")]
            public double Freight;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Tax")]
            [Display(Caption = "Tax")]
            [Binding(Path = "TaxAmt", StringFormat = "{0:c2}")]
            public static string TaxAmt;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Total Due")]
            [Display(Caption = "Total Due")]
            [Binding(Path = "TotalDue", StringFormat = "{0:c2}")]
            public static string TotalDue;
        }

        public class GeneralSection
        {
            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Sales Order Number")]
            [Display(Caption = "Order Number")]
            public static string SalesOrderNumber;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Purchase Order Number")]
            [Display(Caption = "PO Number")]
            public static string PurchaseOrderNumber;

            [Editor(EditorType.Label)]
            [Binding(Path = "Status", ConverterType = typeof(StatusLabelConverter))]
            [StringInput(Placeholder = "Status")]
            [Display(Caption = "Status")]
            public static string Status;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "Order Date")]
            [Display(Caption = "Order Date")]
            [Binding(Path = "OrderDate", StringFormat = "{0:MMM dd, yyyy}")]
            public static DateTime OrderDate;

            [Editor(EditorType.Label)]
            [StringInput(Placeholder = "ShippedDate")]
            [Binding(Path = "ShipDate", StringFormat = "{0:MMM dd, yyyy}")]
            [Display(Caption = "Ship Date", NullValueText = "None")]
            public static DateTime ShipDate;
        }

        public class CommentSection
        {
            [Editor(EditorType.Label)]
            [Layout(Style = LayoutStyle.DetailOnly)]
            [StringInput(Placeholder = "Comment", AcceptLineBreak = true, MaxHeight = 3, MinHeight = 68f)]
            [Display(Caption = "Comment", NullValueText = "None")]
            public static string Comment;
        }

        public class ActionSection
        {
            [Editor(EditorType.Button)]
            [Binding(Path = "SaveCommand", SourceType = BindingSourceType.ViewModel)]
            [Button(Title = "Save", Style = ButtonStyle.Image, TextColor = "#ff000000", BackgroundImage = "greyButton.png greyButtonHighlight.png 6,6,6,6")]
            public static string OKButton;
        }
    }
}
