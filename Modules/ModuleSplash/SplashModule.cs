using GCA.Core;
using Microsoft.Practices.Unity;
using ModuleSplash.Views;
using Prism.Regions;

namespace ModuleSplash
{
    [Roles("User")]
    public class SplashModule : ModuleBase
    {
        public SplashModule(IUnityContainer container, IRegionManager regionManager)
            : base(container, regionManager)
        {

        }

        protected override void InitializeModule()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(SplashButton));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<SplashScreenView>();
        }

    }
}
