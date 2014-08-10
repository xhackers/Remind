

using Remind.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Remind.ViewModel
{
    public class PageViewModelBase : NotifyRootObject
    {
        public INavigation Navigation { get; set; }
        public const string TitlePropertyName = "Title";


        private bool _isbusy;

        public bool IsBusy
        {
            get { return _isbusy; }
            set { _isbusy = value; }
        }


        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }


        private string icon = null;

        public const string IconPropertyName = "Icon";
        public string Icon
        {
            get { return icon; }
            set { icon = value; OnPropertyChanged(); }
        }
    }
}