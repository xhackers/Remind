using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remind.Model
{
    public class SocialInfo
    {
        public string clientId; // your OAuth2 client id
        public string scope; // the scopes for the particular API you're accessing, delimited by "+" symbols
        public Uri authorizeUrl; // the auth URL for the service
        public Uri redirectUrl; // the redirect URL for the service
        public string userInfoAPI;
    }
    public class FacebookInfo : SocialInfo
    {
        public FacebookInfo()
        {
            clientId = "1484841145092065";  // your OAuth2 client id
            scope = "email, user_friends, user_birthday";//"user_about_me,read_stream,email,user_birthday,friends,friendlists"; // the scopes for the particular API you're accessing, delimited by "+" symbols
            authorizeUrl = new Uri("https://m.facebook.com/dialog/oauth/"); // the auth URL for the service
            redirectUrl = new Uri("http://www.facebook.com/connect/login_success.html");// the redirect URL for the service
            userInfoAPI = "https://graph.facebook.com/me";
        }

    }
    public class MicrosoftInfo : SocialInfo
    {
        public MicrosoftInfo()
        {
            clientId = "000000004010E173"; // your OAuth2 client id
            scope = "wl.basic,wl.emails,wl.offline_access"; // the scopes for the particular API you're accessing, delimited by "+" symbols
            authorizeUrl = new Uri("https://login.live.com/oauth20_authorize.srf"); // the auth URL for the service
            redirectUrl = new Uri("https://login.live.com/oauth20_desktop.srf"); // the redirect URL for the service
            userInfoAPI = "https://apis.live.net/v5.0/me";
        }
    }
    public class GoogleInfo : SocialInfo
    {
        public GoogleInfo() // Create Google web app (for the redirectUrl)
        {
            clientId = "315685053117-13a5so111567anib7os7ji4kurrev00a.apps.googleusercontent.com"; // your OAuth2 client id
            scope = "https://www.googleapis.com/auth/userinfo.email"; // the scopes for the particular API you're accessing, delimited by "+" symbols
            authorizeUrl = new Uri("https://accounts.google.com/o/oauth2/auth"); // the auth URL for the service
            redirectUrl = new Uri("http://clastravel.net/", UriKind.Absolute); // the redirect URL for the service 
            userInfoAPI = "https://www.googleapis.com/oauth2/v2/userinfo";
        }
    }

}
