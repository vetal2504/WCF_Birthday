﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebService
{
    public class PersonDb : DbContext
    {
        public PersonDb() : base("People")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}