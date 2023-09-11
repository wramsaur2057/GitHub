using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using DataLayer;

namespace BusinessLogic
{
    class BusinessLogic
    {

        public CustomBO AddEmployee(DataLayer.Employee objNewEmp)
        {
            return new EmployeeDAL().AddEmployee(objNewEmp);

        }

        public List<Employee> GetEmployees()
        {
            List<DataLayer.Employee> list = new List<DataLayer.Employee>();

            //here's where I use Entity Framework to selecft * from Employees


            return list;
        }


    }
}
