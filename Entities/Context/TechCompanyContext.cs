using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class TechCompanyContext : DbContext
    {
        public TechCompanyContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Company> Companies { get; set; }
        DbSet<Employee> Employees { get; set; }

    }
}
