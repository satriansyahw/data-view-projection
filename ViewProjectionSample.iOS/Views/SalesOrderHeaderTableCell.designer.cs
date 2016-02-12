// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ViewProjectionSample.iOS
{
	[Register ("SalesOrderHeaderTableCell")]
	partial class SalesOrderHeaderTableCell
	{
		[Outlet]
		UIKit.UILabel CompanyLabel { get; set; }

		[Outlet]
		UIKit.UILabel CustomerCompanyLabel { get; set; }

		[Outlet]
		Intersoft.Crosslight.iOS.UICellLabel DaysLeftLabel { get; set; }

		[Outlet]
		UIKit.UILabel ItemQuantityLabel { get; set; }

		[Outlet]
		UIKit.UILabel OrderNumberLabel { get; set; }

		[Outlet]
		UIKit.UILabel ShippingAddressLabel { get; set; }

		[Outlet]
		UIKit.UIImageView StatusIcon { get; set; }

		[Outlet]
		UIKit.UILabel StatusLabel { get; set; }

		[Outlet]
		UIKit.UILabel TotalLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomerCompanyLabel != null) {
				CustomerCompanyLabel.Dispose ();
				CustomerCompanyLabel = null;
			}

			if (StatusLabel != null) {
				StatusLabel.Dispose ();
				StatusLabel = null;
			}

			if (StatusIcon != null) {
				StatusIcon.Dispose ();
				StatusIcon = null;
			}

			if (CompanyLabel != null) {
				CompanyLabel.Dispose ();
				CompanyLabel = null;
			}

			if (DaysLeftLabel != null) {
				DaysLeftLabel.Dispose ();
				DaysLeftLabel = null;
			}

			if (ItemQuantityLabel != null) {
				ItemQuantityLabel.Dispose ();
				ItemQuantityLabel = null;
			}

			if (OrderNumberLabel != null) {
				OrderNumberLabel.Dispose ();
				OrderNumberLabel = null;
			}

			if (ShippingAddressLabel != null) {
				ShippingAddressLabel.Dispose ();
				ShippingAddressLabel = null;
			}

			if (TotalLabel != null) {
				TotalLabel.Dispose ();
				TotalLabel = null;
			}
		}
	}
}
