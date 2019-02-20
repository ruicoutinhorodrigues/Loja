using Loja.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Loja.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}