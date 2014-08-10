using System;
using System.Collections.Generic;
using System.Text;

using Remind.Data;

namespace Remind.Model
{
    public class ReminderItem : NotifyRootObject
    {
        public ReminderItem()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public Person Person { get; set; }


        public string Description
        {
            get;
            set;

        }

        public DateTime ReminderDate { get; set; }
    }

}