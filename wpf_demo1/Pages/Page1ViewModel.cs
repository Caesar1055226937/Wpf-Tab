using Prism.Mvvm;

namespace wpf_demo1.Pages
{
    public class Page1ViewModel : BindableBase
    {
        public Page1ViewModel()
        {
            Content = "我是页面1";
        }

        private string _content = string.Empty;
        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }
    }
}
