using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    //Here is where I put any DTOS, custom Models for the presentation layer.  In a larger application I'd probably use a separate project to hold my models.

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string PositionName { get; set; }
        public string EmployeName { get; set; }

    }

    public class NewEmployee
    {
        //in the presentation layer both Position and Paytype would be dropdowns with the values for those individual table,  Save the IDs to Employee
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public decimal PayRate { get; set; }
        public int Paytype { get; set; }
        public decimal MaxAmountExpense { get; set; }

    
    }

    public class CustomBO
    {
        //output a message after save
        public int CustomMessageNumber { get; set; }

        public string CustomMessage { get; set; }
    }

}
