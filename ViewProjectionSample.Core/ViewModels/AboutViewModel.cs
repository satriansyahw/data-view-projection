using System;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ViewProjectionSample.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        #region Fields

        private string _description;

        #endregion

        #region Properties

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public DelegateCommand LearnMoreCommand { get; set; }

        #endregion

        #region Constructors

        public AboutViewModel()
        {
            this.Title = "About";
            this.Description = "This project demonstrates View Projection and Any Filter Descriptor data features and several new component including iOS Cell Label, iOS Segmented Bar Controller and iOS Search Controller that were introduced in Crosslight 4. View Project and Any filter Descriptor feature will surely enable developer to significantly reduce data traffics and handle filter over collection easily without custom server query. With iOS Cell Label, iOS Segmented Bar Controller and iOS Search Controller, creating a stunning application design will be much more easy.";
            this.LearnMoreCommand = new DelegateCommand(ExecuteLearnMore);
        }

        #endregion

        #region Methods

        private void ExecuteLearnMore(object parameter)
        {
            this.MobileService.Browser.Navigate("http://www.intersoftpt.com/crosslight");
        }

        #endregion
    }
}

