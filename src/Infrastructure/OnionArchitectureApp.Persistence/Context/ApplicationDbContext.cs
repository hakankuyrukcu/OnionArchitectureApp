﻿using Microsoft.EntityFrameworkCore;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence.Context
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Product>().HasData(
        new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 10, Quantity = 100, CreatedOn = DateTime.Now },
        new Product() { Id = Guid.NewGuid(), Name = "Paper", Value = 1, Quantity = 1000, CreatedOn = DateTime.Now },
        new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 2, Quantity = 300, CreatedOn = DateTime.Now }
        );

      base.OnModelCreating(modelBuilder);
    }
  }
}
