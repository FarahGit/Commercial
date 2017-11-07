using Prism.Regions;

namespace GCA.Core
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}