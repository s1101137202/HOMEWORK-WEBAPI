using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hw0501.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            CheckEmployeeIsNotNullThrowException(employee);

            try
            {
                EmployeeService.AddEmployee(employee);
                return EmployeeService.GetEmployeeById(employee.Id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        private void CheckEmployeeIsNotNullThrowException(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
