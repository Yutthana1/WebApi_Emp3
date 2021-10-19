using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Emp3.Models;

namespace WebApi_Emp3.Interface
{
    public interface IEmployees
    {
        public IEnumerable<EmpModels> getEmployee();
        public EmpModels getEmployeeBy_ID(int employeeId);
        public int addEmployee(EmpModels empModels);
        public int updateEmployee(EmpModels empModels);
        public int deleteEmployee(int employeeId);
    }
}
