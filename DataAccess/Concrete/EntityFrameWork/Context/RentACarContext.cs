﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork.Context
{
    public class RentACarContext:DbContext
    {
        public RentACarContext()
        {
        }
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           
        //optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database=Northwind;Trusted_COnnection=true");
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyReCap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False").UseLoggerFactory(loggerFactory); 
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }


    }
}
