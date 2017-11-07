using GCA.Core;
using Microsoft.Practices.Prism.Commands;
using Prism.Regions;

namespace GCA.Viewer
{
    public class MainWindowViewModel
    {
        private readonly IRegionManager regionManager;
        public DelegateCommand<object> NavigateCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<object>(Navigate);
            GlobalCommands.NavigateCommand.RegisterCommand(NavigateCommand);
        }

        private void Navigate(object navigationPath)
        {
            if (navigationPath != null)
                regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath.ToString());
        }
    }
}
