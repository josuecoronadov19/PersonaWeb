﻿using Microsoft.EntityFrameworkCore;

namespace PersonaWeb.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
                
        }
        public DbSet<PersonaWeb.Models.Person> Person { get; set; }
    }
}
