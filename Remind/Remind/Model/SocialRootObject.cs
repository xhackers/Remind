using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable InconsistentNaming
namespace Remind.Model
{
    #region Facebook

    public class Year
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Degree
    {
        public string id { get; set; }
        public string name { get; set; }
    }


    public class Hometown
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Employer
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Position
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class FacebookRootObject : SocialRootObject
    {
        public string id { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public string last_name { get; set; }
        public string link { get; set; }
        public string locale { get; set; }
        public string middle_name { get; set; }
        public string name { get; set; }
        public int timezone { get; set; }
        public string updated_time { get; set; }
        public string username { get; set; }
        public bool verified { get; set; }
        public string imageUrl { get; set; }
    }
    #endregion
    
    #region Microsoft
    public class MicrosoftEmails 
    {
        public string preferred { get; set; }
        public string account { get; set; }
        public string personal { get; set; }
        public string business { get; set; }
    }

    public class MicrosoftRootObject : SocialRootObject
    {
        
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string link { get; set; }
        public object gender { get; set; }

        private MicrosoftEmails _emails;
        public MicrosoftEmails emails
        {
            get { return _emails; }
            set
            {
                if (Equals(value, _emails)) return;
                _emails = value;
                email = value.account;
                OnPropertyChanged();
            }
        }

        public string locale { get; set; }
        public string updated_time { get; set; }
    }
    #endregion

    #region Google
    public class GoogleRootObject : SocialRootObject
    {
        public string id { get; set; }
        public string email { get; set; }
        public bool verified_email { get; set; }
        public string name { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string link { get; set; }
        public string picture { get; set; }
        public string gender { get; set; }
    }
    #endregion


    public abstract class SocialRootObject : NotifyRootObject
    {
        public string id { get; set; }
        public string email { get; set; }


    }
}
