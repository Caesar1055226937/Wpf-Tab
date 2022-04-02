using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using wpf_demo1.Model;

namespace wpf_demo1
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Menus.Add(new MenuItem { Name = "Page1", Path = new Uri("Pages/Page1.xaml", UriKind.Relative) });
            Menus.Add(new MenuItem { Name = "Page2", Path = new Uri("Pages/Page2.xaml", UriKind.Relative) });
            Menus.Add(new MenuItem { Name = "UserControl1", Path = new Uri("UserControls/UserControl1.xaml", UriKind.Relative) });
            Menus.Add(new MenuItem { Name = "UserControl2", Path = new Uri("UserControls/UserControl2.xaml", UriKind.Relative) });

            ButtonCommand = new DelegateCommand<MenuItem>(MenuChange);
            ContentRegion = Menus[0].Path;
        }

        public void MenuChange(MenuItem menu)
        {
            ContentRegion = menu.Path;
        }

        public DelegateCommand<MenuItem> ButtonCommand { get; set; }

        private ObservableCollection<MenuItem> _menus = new ObservableCollection<MenuItem>();
        public ObservableCollection<MenuItem> Menus
        {
            get { return _menus; }
            set { SetProperty(ref _menus, value); }
        }

        private Uri _contentRegion;
        public Uri ContentRegion
        {
            get { return _contentRegion; }
            set { SetProperty(ref _contentRegion, value); }
        }
    }
}
