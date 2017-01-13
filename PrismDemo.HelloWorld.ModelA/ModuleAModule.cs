using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Regions;
using PrismDemo.HelloWorld.ModelA.Views;

namespace PrismDemo.HelloWorld.ModelA
{
    public class ModuleAModule : IModule
    {
        private IRegionManager _regionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            //throw new NotImplementedException();
            _regionManager.RegisterViewWithRegion("ModuleA", typeof(ViewA));

        }
    }
}
