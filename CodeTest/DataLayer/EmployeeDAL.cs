using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;

namespace DataLayer
{
    public class EmployeeDAL
    {
        private TestEntities objUserDBEntities;

        public EmployeeDAL()
        {
            objUserDBEntities = new TestEntities();
        }

        public CustomBO AddEmployee(Employee objNewEmp)
        {
            CustomBO message = new CustomBO();
            objUserDBEntities.Employees.Add(objNewEmp);

            int ReturnValue = objUserDBEntities.SaveChanges();
            if (ReturnValue > 0)
            {
                message.CustomMessage = "Saved!";
                message.CustomMessageNumber = ReturnValue;
            }
            else
            {
                message.CustomMessage = "Error! Can't Save.";
                message.CustomMessageNumber = ReturnValue;

            }

            return message;
        }

        public List<Employee> GetEmployees()
        {

        }

    }
}

