using Prism.Mvvm;

namespace GCA.Core
{
    public abstract class ViewModelBase : BindableBase
    {
        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }


    }
}
