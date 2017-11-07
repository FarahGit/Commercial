using GCA.Core;
using Microsoft.Practices.Unity;
using ModuleLogin.Views;
using Prism.Regions;

namespace ModuleLogin
{
    [Roles("Admin")]
    public class LogInModule : ModuleBase
    {

        public LogInModule(IUnityContainer container, IRegionManager regionManager)
            : base(container, regionManager)
        {

        }

        protected override void InitializeModule()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(LogInButton));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<LogInView>();
        }
    }
}
