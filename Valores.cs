using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     class Valores
    {
        private double valor1;
        private double valor2;

        //Encapsulación de los datos a utilizar en los métodos

        public double Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

    }
}
