using Remind.Common;
using Remind.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remind.Models
{
   public class Person :NotifyPropertyChanged
    {
        public Person()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Birthdate { get; set; }   
    }
}
