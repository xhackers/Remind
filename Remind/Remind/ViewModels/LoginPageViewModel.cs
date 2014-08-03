using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Remind.Common;
using Remind.Models;

namespace Remind.ViewModels
{
    public class LoginPageViewModel : PageViewModelBase
    {
        #region Properties

        public List<Person> ReminderList { get; set; }

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
            //ReminderList = new List<ReminderListItem>();

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