using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion4.clases
{
    /*Calcular el salario neto del empleado*/
    internal class Empleado
    {
        public Empleado() { }

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public string Phone { get; set; }   
        public double Salary { get; set; }

        public Empleado(string iD, string firstName, string lastName, string email, string phone, double salary)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }
}
