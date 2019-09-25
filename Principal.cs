using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Principal
    {
        
        public void Bienvenida()                //Método que muestra un saludo al usario al inciar el programa
        {
            Console.WriteLine("CALCULADORA ARITMETICA\nGarcía Vázquez Oscar Daniel\n");
            Menu();         //Se ejecuta el método Menú
        }


        public void Menu()              //Método que muestra un pequeño menú para que el usuario pueda elegir la operación que quiera realizar
        {
            Operacion op = new Operacion();         //Para esto, debo instanciar un objeto de la clase operacion para utilizar sus metodos suma resta multiplicacion y division

            Valores x = new Valores();              //y un objeto de la clase valores para utilizar sus variables para guardar los datos ingresados por el usuario
         
            int n; 
            double res; //La variable n se utiliza para la condición a la hora de elegir una opción del menú
            //la variable res guardará el valor retornado por el método que realize la opción seleccionada



            Console.WriteLine("Seleccione la operación a realizar\n1.-Sumar\n2.-Restar\n3.-Multiplicar\n4.-Dividir\n5.-Salir");     //Menú que se mostrará al usuario
            n = Convert.ToInt32(Console.ReadLine());
            if (n != 5) {       //Si el valor ingresado por el usario es diferente de 5 entonces el programa le pedirá 2 valores numericos
                Console.WriteLine("Ingrese un valor");
                x.Valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese un valor");
                x.Valor2 = Convert.ToDouble(Console.ReadLine());        //Los valores ingresados se guardarán en las variables que he declarado en la clase valores
                switch (n)                          
                {
                    case 1: res = op.Sumar(x.Valor1, x.Valor2);         //Si el usuario introduce 1, mostrará el resultado de la suma de los valores que ingresó
                        Console.WriteLine("El resultado de {0} + {1} es: {2}\n", x.Valor1, x.Valor2, res);
                        break;
                    case 2: res = op.Restar(x.Valor1, x.Valor2);        //Si el usuario introduce 2 mostrará el resultado de la resta de los valores que ingresó
                        Console.WriteLine("El resultado de {0} - {1} es: {2}\n", x.Valor1, x.Valor2, res);
                        break;
                    case 3: res = op.Multiplicar(x.Valor1, x.Valor2);   //Si el usuario introduce 3, mostrará el resultado del producto de los valores que ingresó
                        Console.WriteLine("El resultado de {0} * {1} es: {2}\n", x.Valor1, x.Valor2, res);
                        break;
                    case 4: res = op.Dividir(x.Valor1, x.Valor2);           //Si el usuario introduce 4, mostrará el resultado de la división de los valores que ingresó
                        Console.WriteLine("El resultado de {0} / {1} es: {2}\n", x.Valor1, x.Valor2, res);
                        break;
                    default: Console.WriteLine("Debe ingresar un valor valido\n");      //En caso de introducir cualquier otro valor que no se encuentre en el switch o en el if,
                        //mostrará el mensaje de que la opción es invalida y volverá al menú

                        break;

                }
                
                Menu();     //Se vuelve a ejecutar el menú en caso de que el usario quiera realizar otra operación
            }
            else
            {
                Console.WriteLine("ADIOS");     //Si el valor ingresado es 5 entonces terminará el programa y mostrará un mensaje
                
            }
           
            Console.ReadKey();
            
        }



    }
}
