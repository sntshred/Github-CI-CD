﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Github_CI_CD
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

    }

    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options) :base(options)
        {

        }
       
    }


}
