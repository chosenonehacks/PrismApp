using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB
{
    public class ModuleB : IModule
    {
        protected IRegionManager RegionManager { get; private set; }

        public ModuleB(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion("MenuRegion", typeof(ButtonViewB));
            
        }
    }
}
