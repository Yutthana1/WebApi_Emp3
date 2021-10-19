using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Emp3.Interface;
using WebApi_Emp3.Models;

namespace WebApi_Emp3.Repository
{
    public class EmployeeRepository : IEmployees
    {
        
        private ContextDbEmp _contextDb;
        public EmployeeRepository(ContextDbEmp contextDb)
        {
            this._contextDb = contextDb;
        }

        public int addEmployee(EmpModels empModels)
        {
            _contextDb.Tb_employees.Add(empModels);
           int savedata = _contextDb.SaveChanges();
           return savedata;
                       
        }

        public int deleteEmployee(int employeeId)
        {
           var emp = _contextDb.Tb_employees.Find(employeeId);
            if (emp != null)
            {
                _contextDb.Tb_employees.Remove(emp);
                int deleteRecord = _contextDb.SaveChanges();
                return deleteRecord;
            }
            else {
                return 0;
            }
            
        }

        public IEnumerable<EmpModels> getEmployee()
        {
            return _contextDb.Tb_employees.ToList();
            
        }

        public EmpModels getEmployeeBy_ID(int employeeId)
        {
            var emp = _contextDb.Tb_employees.Find(employeeId);
            if (emp != null)
            {
                return emp;
            }
            else {
                return null;
            }
        }

        public int updateEmployee(EmpModels empModels)
        {
            var empData = _contextDb.Tb_employees.Find(empModels.emp_ID);
            if (empData != null)
            {
              
                empData.address = empModels.address;
                empData.dateTime = empModels.dateTime;
                // empData.dateTime = DateTime.Parse(empModels.dateTime.ToString());
                empData.designation = empModels.designation;
                empData.nameEmp = empModels.nameEmp;
                empData.salary = empModels.salary;
                int resultDb = _contextDb.SaveChanges();
                return resultDb;
            }
            else
            {
                return 404;
            }

            
        }


    }
}
