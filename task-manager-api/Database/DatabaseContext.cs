using System;
using Microsoft.EntityFrameworkCore;
using task_manager_api.Models;

namespace task_manager_api.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
