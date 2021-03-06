﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LeaveAvailable> LeaveAvailables { get; set; }

    }
}
