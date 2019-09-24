
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Context
{
    public class StoreContext:DbContext
    {
        //Se agrego el atributo Products, va a representar todos los productos que estan en la base de datos.
        public DbSet<Models.Product> Products { get; set; }
    }
}