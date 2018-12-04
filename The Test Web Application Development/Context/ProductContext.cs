using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using The_Test_Web_Application_Development.Models;

namespace The_Test_Web_Application_Development.Context
{
    public class ProductContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}