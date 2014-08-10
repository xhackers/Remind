using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Remind.Model;
using System.Collections.ObjectModel;

namespace Remind.ViewModel
{
    public class LoginPageViewModel : PageViewModelBase
    {
        #region Properties

        private SocialRootObject _socialRootObject;

        public SocialRootObject SocialRootObject
        {
            get { return _socialRootObject; }
            set
            {
                if (Equals(value, _socialRootObject)) return;
                _socialRootObject = value;
                OnPropertyChanged();
            }
        }

        public List<Person> ReminderList { get; set; }

        public ObservableCollection<ReminderItem> ReminderItemList { get; set; }

        #endregion

        #region Ctor
        public LoginPageViewModel()
        {

        }

        #endregion

        #region Implementation

        public void PopulateReminderList()
        {
            //Populate complete list inside Reminder list
            ReminderItemList = new ObservableCollection<ReminderItem>();

            ReminderItemList.Add(new ReminderItem { Id = 1, Description = "desc1" });
            ReminderItemList.Add(new ReminderItem { Id = 2, Description = "desc2" });
            ReminderItemList.Add(new ReminderItem { Id = 3, Description = "desc3" });

            //foreach (var item in new ReminderItemDatabase().GetItems())
            //{
            //    ReminderList.Add(new ReminderListItem { Id = item.Id, VehiclePhoto = item.VehicleType + ".png", Name = item.Name, NextServiceDate = item.NextServiceDate.ToString("d") });

            //}
        }

        public void loginfb()
        {
            IsBusy = true;

            //use OAuth to login

            //get contacts list from FB

            //Create a contact item for item returned 

            //Create a reminder and insert contact inside that

            //push entire data into SQLite

            //in the handler function set
            IsBusy = false;

            //Navigate to next page
        }

        #endregion
    }
}