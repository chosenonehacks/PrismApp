using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB
{
    public class ButtonViewBViewModel : INotifyPropertyChanged
    {
        private readonly IRegionManager regionManager;
        public DelegateCommand SwitchViewCommand { get; set; }

        public ButtonViewBViewModel()
        {
            regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            SwitchViewCommand = new DelegateCommand(SwitchView);
        }

        private void SwitchView()
        {
            regionManager.RequestNavigate("MainRegion", new Uri("ModuleBView", UriKind.Relative));                       
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
