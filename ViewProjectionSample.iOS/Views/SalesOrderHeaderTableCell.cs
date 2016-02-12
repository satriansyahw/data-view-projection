using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ViewProjectionSample.iOS
{
    public partial class SalesOrderHeaderTableCell : UITableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("SalesOrderHeaderTableCell", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("SalesOrderHeaderTableCell");

        public SalesOrderHeaderTableCell(IntPtr handle) : base (handle)
        {
        }

        public static SalesOrderHeaderTableCell Create()
        {
            return (SalesOrderHeaderTableCell)Nib.Instantiate(null, null)[0];
        }

        public override NSObject ValueForUndefinedKey(NSString key)
        {
            return null;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.DaysLeftLabel.Layer.CornerRadius = this.DaysLeftLabel.Frame.Height/2;
            this.DaysLeftLabel.ClipsToBounds = true;
        }
    }
}

