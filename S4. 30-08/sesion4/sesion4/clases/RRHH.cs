using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion4.clases
{
    internal class RRHH
    {
        public double Porcentaje { get; set; }
        public double Techo {  get; set; }

        public RRHH(double porcentaje, double techo)
        {
            Porcentaje = porcentaje;
            Techo = techo;
        }



        /*Calcular el salario neto del empleado*/
        public RRHH() { }
        public double CalcularSalario(Empleado empleado, double deducciones)
        {
            return empleado.Salary = deducciones;
        }
        //Aumentar el salario en un x% si salario base es menor a xSalario
        public void AumentarSalario(Empleado empleado, double porcentaje, double techo)
        {
            empleado.Salary = (empleado.Salary <= techo) ? empleado.Salary =
                (empleado.Salary * (1 + porcentaje)) : empleado.Salary;

        }
    }
}
