using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ViewProjectionSample.BindingProviders;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.iOS.ViewControllers
{
    [Register("SalesOrderHeaderListViewController")]
    [ImportBinding(typeof(SalesOrderHeaderListBindingProvider))]
    public class SalesOrderHeaderListViewController : UITableViewController<SalesOrderHeaderListViewModel>
    {
        public SalesOrderHeaderListViewController()
        {
            this.Appearance.HideSeparatorOnEmptyCell = true;
        }

        public override TableViewInteraction InteractionMode
        {
            get
            {
                return TableViewInteraction.Standard;
            }
        }

        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Custom;
            }
        }

        public override UIViewTemplate CellTemplate
        {
            get
            {
                return new UIViewTemplate(SalesOrderHeaderTableCell.Nib);
            }
        }

        public override string CellIdentifier
        {
            get
            {
                return "SalesOrderHeaderTableCell";
            }
        }
    }
}
