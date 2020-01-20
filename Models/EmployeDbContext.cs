using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp2_MVC.Models
{
    public class EmployeDbContext : DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options) : base(options)
        {

        }
    }
}
