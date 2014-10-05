using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
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
        protected IUnityContainer Container { get; private set; }

        public ModuleB(IRegionManager regionManager, IUnityContainer container)
        {
            Container = container;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            Container.RegisterType<Object, ModuleBView>(typeof(ModuleBView).Name);
            RegionManager.RegisterViewWithRegion("MenuRegion", typeof(ButtonViewB));  
        }
    }
}
