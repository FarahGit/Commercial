using GCA.Core;
using Prism.Events;
using System.Windows;
using System.Windows.Input;

namespace ModuleLogin.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private IEventAggregator eventAggregator;
        public ICommand LoginCommand { get; private set; }


        public LoginViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        private int attempts;

        public int Attempts
        {
            get { return attempts; }
            set
            {
                if (value != attempts)
                    attempts = value;
                SetProperty(ref attempts, value);
            }
        }

        public Visibility ShowInvalidCredentials
        {
            get
            {
                if (attempts > 0)
                    return Visibility.Visible;
                return Visibility.Hidden;
            }

        }

    }
}
