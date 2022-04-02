using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_demo1.UserControls
{
    public class UserControl2ViewModel : BindableBase
    {
        public UserControl2ViewModel()
        {
            Content = "我是用户控制界面2";
        }

        private string _content = string.Empty;
        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }
    }
}
