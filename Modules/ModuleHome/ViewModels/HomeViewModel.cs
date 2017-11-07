using Prism.Events;

namespace ModuleHome.ViewModels
{
    public class HomeViewModel
    {
        private IEventAggregator eventAggregator;

        public HomeViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }
    }
}
