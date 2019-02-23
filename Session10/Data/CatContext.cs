using System;
using Microsoft.EntityFrameworkCore;
using Session10.Data.Entities;

namespace Session10.Data
{
    public class CatContext: DbContext
    {
        public CatContext(DbContextOptions<CatContext> options): base(options)
        {}

        
        public DbSet<Cat> Cats {get; set;}
        public DbSet<Order> Orders {get;set;}
    }
}