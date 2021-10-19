using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Emp3.Models
{
    public class ContextDbEmp : DbContext
    {
        public DbSet<EmpModels> Tb_employees { get; set; }
    }
}
