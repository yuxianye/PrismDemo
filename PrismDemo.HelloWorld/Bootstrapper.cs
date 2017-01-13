using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;
using Microsoft.Practices.Unity;
using Prism.Modularity;

namespace PrismDemo.HelloWorld
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            //return base.CreateShell();
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            //base.InitializeShell();
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            //base.ConfigureModuleCatalog();
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(PrismDemo.HelloWorld.ModelA.ModuleAModule));
            //catalog.AddModule(typeof(PrismDemo.HelloWorld.ModelB.ModuleBModule));
        }
    }
}
