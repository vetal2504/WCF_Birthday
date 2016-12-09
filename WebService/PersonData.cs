using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebService
{
    public class PersonData : DbContext
    {
        public PersonData() : base("DatabaseBirthday")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}