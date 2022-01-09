using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodoCase.Core.Entities;

namespace TodoCase.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<PersonAdresses> PersonAdresses { get; set; }
        public DbSet<PersonelTask> PersonelTask { get; set; }
        public DbSet<Task> Task { get; set; }

    }
}
