using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetbdtnS8.Models;

namespace projetbdtnS8.Data
{
    public class API_ISNContext : DbContext
    {
        public API_ISNContext(DbContextOptions<API_ISNContext> options)
            : base(options)
        {
        }

        public DbSet<projetbdtnS8.Models.User> User { get; set; }
    }
}
