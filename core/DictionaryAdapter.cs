using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DBFill.Core
{
    class DictionaryAdapter
    {
        private readonly string dbPath;
        public DictionaryAdapter(string dbPath)
        {
            this.dbPath = dbPath;
        }
    }
}