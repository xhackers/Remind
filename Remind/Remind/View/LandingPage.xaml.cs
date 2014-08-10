using Remind.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remind.View
{
	public partial class LandingPage:BaseContentPage
	{
        private LoginPageViewModel ViewModel
        {
            get { return BindingContext as LoginPageViewModel; }
        }
		public LandingPage ()
		{
			InitializeComponent ();

            BindingContext = new LoginPageViewModel();


		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.SocialRootObject = App.SocialRootObject;
            ViewModel.PopulateReminderList();
            listView.ItemsSource = ViewModel.ReminderItemList;
        }
        
	}
}
