using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Remind.Droid;
using Remind.View;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LoginOathPage), typeof(LoginOathPageRenderer))]
namespace Remind.Droid
{
    public class LoginOathPageRenderer : PageRenderer
    {
        protected override void OnModelChanged(VisualElement oldModel, VisualElement newModel)
        {
            base.OnModelChanged(oldModel, newModel);

            // this is a ViewGroup - so should be able to load an AXML file and FindView<>
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: LoginOathPage.SocialInfo.clientId, // your OAuth2 client id
                scope: LoginOathPage.SocialInfo.scope, // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: LoginOathPage.SocialInfo.authorizeUrl, // the auth URL for the service
                redirectUrl: LoginOathPage.SocialInfo.redirectUrl); // the redirect URL for the service
            auth.ClearCookiesBeforeLogin = false;
            auth.Completed += async (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, eventArgs.Account);
                    try
                    {
                        Response response = await request.GetResponseAsync();
                        var json = (response.GetResponseText());

                        //Debug.WriteLine("Name: " + obj["name"]);

                        

                        
                        if (eventArgs.IsAuthenticated)
                        {
                            // Use eventArgs.Account to do wonderful things
                            Remind.App.ParseSocial(json,LoginOathPage.SocialInfo);
                            Remind.App.SuccessfulLoginAction.Invoke();
                        }
                        else
                        {
                            // The user cancelled


                        }
                    }

                    catch (OperationCanceledException)
                    {
                        System.Diagnostics.Debug.WriteLine("Canceled");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    // The user cancelled
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }
    }

}
