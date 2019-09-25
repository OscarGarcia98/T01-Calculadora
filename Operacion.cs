using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        //En esta clase se encuentran declarados los métodos para realizar las operaciones basicas de una calculadora
        
        
        public double Sumar(double num1, double num2)
        {
            
            return num1 + num2;     //Método sumar que regresa el resultado de una suma de 2 datos introducidos por el usuario
        }

        public double Restar(double num1, double num2)
        {

            return num1 - num2;         //Método Restar que regresa el resultado de una resta de 2 datos introducidos por el usuario
        }
        public double Multiplicar(double num1, double num2)
        {

            return num1 * num2;         //Método Multiplicar que regresa el resultado de una multiplicación de 2 datos introducidos por el usuario
        }

        public double Dividir(double num1, double num2)
        {

            return num1 / num2;             //Método Dividir que regresa el resultado de una división de 2 datos introducidos por el usuario
        }

    }
}
