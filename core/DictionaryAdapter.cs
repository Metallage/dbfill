using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DBFill.Core
{
    class DictionaryAdapter : DbContext
    {
        private readonly string dbPath;
        
        public DbSet<FirstName> FirstNames {get; set;}
        public DbSet<City> Cities {get; set;}

        public DbSet<LastName> LastNames {get; set;}
        
        public DictionaryAdapter(string dbPath)
        {
            this.dbPath = dbPath;
        }
    }
}