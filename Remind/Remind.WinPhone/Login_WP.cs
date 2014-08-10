using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Json;
using System.Reflection;
using Remind;
using Remind.Model;
using Remind.WinPhone;
using Xamarin.Auth;
using Xamarin.Forms;

[assembly: Dependency(typeof(Login_WP))]
namespace Remind.WinPhone
{
    public class Login_WP : ILogin
    {
        public void Show(SocialInfo socialInfo)
        {
           // IEnumerable<Account> accounts = AccountStore.Create().FindAccountsForService("Facebook");

            var auth = new OAuth2Authenticator(
                clientId: socialInfo.clientId, // your OAuth2 client id
                scope: socialInfo.scope, // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: socialInfo.authorizeUrl, // the auth URL for the service
                redirectUrl: socialInfo.redirectUrl); // the redirect URL for the service
            auth.ClearCookiesBeforeLogin = false;
            // If authorization succeeds or is canceled, .Completed will be fired.
            auth.Completed += async (sender, eventArgs) =>
            {
                if (!eventArgs.IsAuthenticated)
                {
                    Debug.WriteLine("Not Authenticated");
                    return;
                }
                else
                {
                    // Now that we're logged in, make a OAuth2 request to get the user's info.
                    var request = new OAuth2Request("GET", new Uri(socialInfo.userInfoAPI), null, eventArgs.Account);
                    try
                    {
                        Response response = await request.GetResponseAsync();
                        var json = (await response.GetResponseTextAsync());

                        //Debug.WriteLine("Name: " + obj["name"]);



                        if (eventArgs.IsAuthenticated)
                        {
                            // Use eventArgs.Account to do wonderful things
                            //dynamic foo = JsonObject.Parse(json);
                            Remind.App.ParseSocial(json, socialInfo);
                            Remind.App.SuccessfulLoginAction.Invoke();

                        
                        }
                        else
                        {
                            // The user cancelled

                            
                        }
                    }

                    catch (OperationCanceledException)
                    {
                        Debug.WriteLine("Canceled");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            };

            Uri uri = auth.GetUI() as Uri;
            App.RootFrame.Navigate(uri);
        }
    }
}
