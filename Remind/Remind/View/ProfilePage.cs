using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remind.ViewModel;
using Xamarin.Forms;
using Remind.Model;

namespace Remind.View
{
    public class ProfilePage : BaseContentPage
    {
        private ProfileViewModel ViewModel
        {
            get { return BindingContext as ProfileViewModel; }
        }
        public ProfilePage()
        {
            BindingContext = new ProfileViewModel();
            var stack = new StackLayout();
            //var email = new Label()
            //{
          //      VerticalOptions = LayoutOptions.CenterAndExpand,
          //      HorizontalOptions = LayoutOptions.CenterAndExpand
           // };
          //  email.SetBinding(Label.TextProperty, "SocialRootObject.email");
          //  var title = new Label()
          //  {
          //      Text = "Profile Page",
          //      VerticalOptions = LayoutOptions.CenterAndExpand,
          //      HorizontalOptions = LayoutOptions.CenterAndExpand,
          //  };

           // stack.Children.Add(title);
           // stack.Children.Add(email);
           
            Content = stack;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.SocialRootObject = App.SocialRootObject;
        }
    }
}
