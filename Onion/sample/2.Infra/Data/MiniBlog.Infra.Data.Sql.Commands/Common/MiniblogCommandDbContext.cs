﻿using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Domain.Blogs.Entities;
using Zamin.Infra.Data.Sql.Commands;

namespace MiniBlog.Infra.Data.Sql.Commands.Common
{
    public class MiniblogCommandDbContext : BaseCommandDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Person> People { get; set; }
        public MiniblogCommandDbContext(DbContextOptions<MiniblogCommandDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
