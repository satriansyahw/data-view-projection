using System.Collections.Generic;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ViewProjectionSample.ViewModels
{
    public class SalesOrderHeaderMultiPageViewModel : MultiPageViewModelBase
    {
        #region Constructors

        public SalesOrderHeaderMultiPageViewModel()
        {
            List<NavigationItem> items = new List<NavigationItem>();
            items.Add(new NavigationItem("Pending", typeof(SalesOrderHeaderListViewModel)));
            items.Add(new NavigationItem("Complete", typeof(SalesOrderHeaderListViewModel)));
            items.Add(new NavigationItem("About", typeof(AboutViewModel)));
            this.Items = items.ToArray();

            IApplicationContext context = this.GetService<IApplicationService>().GetContext();
            if (context.Platform.OperatingSystem == OSKind.iOS)
                this.SearchCommand = new DelegateCommand(ExecuteSearchCommand);
        }

        #endregion

        #region Properties

        public DelegateCommand SearchCommand { get; set; }

        #endregion

        #region Methods

        public async void ExecuteSearchCommand(object parameter)
        {
            // Exit if current selectedViewModel not SalesOrderHeaderListViewModel.
            if (!(this.SelectedViewModel is SalesOrderHeaderListViewModel))
            {
                this.ToastPresenter.Show("Search function is not available for this view.");
                return;
            }

            var result = await this.NavigationService.NavigateAsync(
                             new NavigationTarget(typeof(SalesOrderHeaderListViewModel), "SalesOrderHeaderSearch",
                                 NavigationMode.Modal, false));

            if (result.Action == NavigationResultAction.Done && result.Data != null)
            {
                var listViewModel = this.SelectedViewModel as SalesOrderHeaderListViewModel;
                this.GetService<IViewService>().RunOnUIThread(() =>
                {
                    listViewModel.ExecuteSearchSelect(result.Data);
                });
            }
        }

        #endregion
    }
}