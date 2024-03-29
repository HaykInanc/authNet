﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Microsoft.EntityFrameworkCore;
 
namespace ingosAu.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}