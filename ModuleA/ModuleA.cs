using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA
{
    public class ModuleA : IModule
    {
        protected IRegionManager RegionManager { get; private set; }
        protected IUnityContainer Container { get; private set; }

        public ModuleA(IRegionManager regionManager, IUnityContainer container)
        {
            Container = container;
            RegionManager = regionManager;
        }

        public void Initialize()
        {            
            Container.RegisterType<Object, ModuleAView>(typeof(ModuleAView).Name);            
            RegionManager.RegisterViewWithRegion("MenuRegion", typeof(ButtonViewA));            
        }
    }
}
