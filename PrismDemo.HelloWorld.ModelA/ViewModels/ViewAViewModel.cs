using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.HelloWorld.ModelA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel()
        {

        }

        private string _title = "你好 Prism";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }

        }
    }
}
