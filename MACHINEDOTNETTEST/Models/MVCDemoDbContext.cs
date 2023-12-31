﻿using MACHINEDOTNETTEST.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MACHINEDOTNETTEST.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}

