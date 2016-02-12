using Android.Runtime;
using Android.Views;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using System;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Android.Activities
{
    public class SalesOrderHeaderDetailFormFragment : Intersoft.Crosslight.Android.v7.FormFragment<SalesOrderHeaderDetailViewModel>
    {
        #region Constructors

        public SalesOrderHeaderDetailFormFragment()
            : base()
        {
        }

        public SalesOrderHeaderDetailFormFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();
            
            this.AddBarItem(new BarItem("SaveButton", CommandItemType.Done));
        }

        #endregion
    }
}