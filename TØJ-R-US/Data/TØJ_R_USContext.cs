using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TØJ_R_US.Models;

namespace TØJ_R_US.Data
{
    public class TØJ_R_USContext : DbContext
    {
        public TØJ_R_USContext (DbContextOptions<TØJ_R_USContext> options)
            : base(options)
        {
        }

        public DbSet<TØJ_R_US.Models.Product> Product { get; set; }
    }
}
