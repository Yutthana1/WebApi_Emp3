
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApi_Emp3.Models;
using WebApi_Emp3.Repository;

namespace WebApi_Emp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmpController : ControllerBase
    {
        private EmployeeRepository _employeeRepository;
        public EmpController() {
            this._employeeRepository = new EmployeeRepository(new ContextDbEmp());
        }

        [HttpGet]
        [Route("getAllEmployees")]
        public ActionResult<IEnumerable<EmpModels>> GetEmployee() {

            return Ok(_employeeRepository.getEmployee());
        }

        [HttpGet]
        [Route("getEmployeesBy_ID/{id:int}")]
        public ActionResult<EmpModels> getemployeeBy_Id(int id) {
            var empObj = _employeeRepository.getEmployeeBy_ID(id);
            if (empObj != null)
            {
                return Ok(empObj);
            }
            else {
                return Ok("Can't found Employees!!!.");
            }

        }

        [HttpPut]
        [Route("updateEmployees")]
        public ActionResult<int> updateEmployee([FromBody] EmpModels empModels) {

            return Ok(_employeeRepository.updateEmployee(empModels));
        }

        [HttpPost]
        [Route("insertEmployees")]
        public IActionResult addEmployees([FromBody] EmpModels empModels) {
            int saveCode = _employeeRepository.addEmployee(empModels);
            if (saveCode == 1)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            else {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

        }

        [HttpDelete]
        [Route("deleteEmployees/{id:int}")]
        public ActionResult<int> deleteEmployees(int id) {
           int deleteReocrd = _employeeRepository.deleteEmployee(id);
            return Ok(deleteReocrd);
        }

    }
}
