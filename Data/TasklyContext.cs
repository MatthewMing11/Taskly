using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taskly.Models;

namespace Taskly.Data
{
    public class TasklyContext : DbContext
    {
        public TasklyContext (DbContextOptions<TasklyContext> options)
            : base(options)
        {
        }

        public DbSet<Taskly.Models.Task> Task { get; set; } = default!;
    }
}
