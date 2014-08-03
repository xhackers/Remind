using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remind.Model;
using Xamarin.Forms;

namespace Remind.View
{
    public class LoginPage : ContentPage
    {

        public LoginPage()
        {
            var stack = new StackLayout();
            var label = new Label()
            {
                Text = "Login Page",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var facebookButton = new Button()
            {
                Text = "Facebook Login"

            };
            SetClicked<FacebookRootObject>(facebookButton,new FacebookInfo());

            var microsoftButton = new Button()
            {
                Text = "Microsoft Login"

            };
            SetClicked<MicrosoftRootObject>(microsoftButton, new MicrosoftInfo());

            var googleButton = new Button()
            {
                Text = "Google Login"

            };
            SetClicked<GoogleRootObject>(googleButton, new GoogleInfo());

            stack.Children.Add(label);
            stack.Children.Add(facebookButton);
            stack.Children.Add(microsoftButton);
            stack.Children.Add(googleButton);
            Content = stack;

        }

        private void SetClicked<T>(Button button, SocialInfo socialInfo)
        {
            if (Device.OS == TargetPlatform.WinPhone)
                button.Clicked += (sender, e) => DependencyService.Get<ILogin>().Show(socialInfo);
            else
                button.Clicked += (sender, e) => Navigation.PushModalAsync(new LoginOathPage(socialInfo));
        }
    }

}

