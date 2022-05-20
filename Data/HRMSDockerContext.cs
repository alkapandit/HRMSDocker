using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMSDCocker.Models;

namespace HRMSDocker.Data
{
    public class HRMSDockerContext : DbContext
    {
        public HRMSDockerContext (DbContextOptions<HRMSDockerContext> options)
            : base(options)
        {
        }

        public DbSet<HRMSDCocker.Models.House>? House { get; set; }
    }
}
