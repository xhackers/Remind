
using Remind.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remind.Model
{
    public class Person : NotifyRootObject
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
