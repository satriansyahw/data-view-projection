using Intersoft.AppFramework;
using Intersoft.AppFramework.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using System.Linq;
using ViewProjectionSample.DomainModels;
using ViewProjectionSample.Models;

namespace ViewProjectionSample.ViewModels
{
    public class SalesOrderHeaderListViewModel : DataListViewModelBase<SalesOrderHeader, ISalesOrderHeaderRepository>
    {
        #region Constructors

        public SalesOrderHeaderListViewModel()
        {
            this.Title = "Sales Order List";
            // enable pull to refresh 
            this.EnableRefresh = true;

            // enable incremental refresh
            this.EnableIncrementalRefresh = true;

            // enable incremental loading
            this.EnableIncrementalLoading = false;
            this.LoadIncrementalCommand = new DelegateCommand(ExecuteLoadIncrementalCommand, CanExecuteLoadIncrementalCommand);

            // enable async filter
            this.EnableAsyncFilter = true;
        }

        #endregion

        #region Fields

        private SalesOrderHeaderQueryDefinition _viewQueryDefinition;

        #endregion

        #region Properties

        protected override IQueryDefinition FilterQuery
        {
            get
            {
                return this.ViewQuery;
            }
        }

        protected override IQueryDefinition ViewQuery
        {
            get
            {
                if (_viewQueryDefinition == null)
                    _viewQueryDefinition = new SalesOrderHeaderQueryDefinition();
                return _viewQueryDefinition;
            }
        }

        public DelegateCommand LoadIncrementalCommand { get; set; }


        // Determine whether current state is in Search State.
        protected bool IsSearchState { get; set; }

        #endregion

        #region Methods

        private bool CanExecuteLoadIncrementalCommand(object paramater)
        {
            return this.EnableIncrementalLoading;
        }

        private void ExecuteLoadIncrementalCommand(object parameter)
        {
            this.LoadDataIncremental();
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            NavigationItem navigationItem = parameter.Data as NavigationItem;

            if (navigationItem != null)
            {
                (this.ViewQuery as SalesOrderHeaderQueryDefinition).ViewScope = navigationItem.Title;
                this.IsDataLoaded = false;
                this.IsSearchState = false;
                this.AutoLoadData = true;
            }
            else
            {
                // View Model was on Search State
                this.IsSearchState = true;
                this.EnableRefresh = false;
                this.AutoLoadData = false;
                this.EnableIncrementalLoading = false;
                this.IncrementalLoadingSize = 0;
            }

            base.Navigated(parameter);
        }

        // Provide access to invoke ExecuteSelect method.
        public void ExecuteSearchSelect(object parameter)
        {
            this.ExecuteSelect(parameter);
        }

        protected override void ExecuteSelect(object parameter)
        {
            base.ExecuteSelect(parameter);

            // Disabled Navigation Select Action on Editing Mode.
            if (!this.IsEditing)
            {
                if (this.IsSearchState)
                {
                    // Close this Modal and set the Result Action as Done.
                    // This will later be further process by Result Callback.
                    this.NavigationService.Close(new NavigationResult(NavigationResultAction.Done, parameter));
                }
                else
                {
                    // Navigate to Detail View if not in Search State
                    this.NavigationService.Navigate<SalesOrderHeaderDetailViewModel>(new NavigationParameter(parameter));
                }
            }
        }

        #endregion
    }
}