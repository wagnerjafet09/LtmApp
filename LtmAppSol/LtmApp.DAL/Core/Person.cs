using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Core
{
    public abstract class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}