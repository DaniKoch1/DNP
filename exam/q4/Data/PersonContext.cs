using System;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options){}
        public DbSet<Person> People {get;set;}
    }
}