using Prism.Mvvm;

namespace wpf_demo1.Pages
{
    public class Page2ViewModel : BindableBase
    {
        public Page2ViewModel()
        {
            Content = "我是页面2";
        }

        private string _content = string.Empty;
        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }
    }
}
