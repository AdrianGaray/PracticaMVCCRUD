
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Context
{
    public class StoreContext:DbContext
    {
        public DbSet<Models.Product> Products { get; set; }
    }
}