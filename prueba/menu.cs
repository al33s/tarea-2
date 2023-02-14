using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class menu
    {

        int opcion;

        public void principal()
        {

            do
            {
                
                Console.WriteLine(" 1- agregar estudiantes");
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine(" 3- consultar estudiantes");
                Console.WriteLine();
                Console.WriteLine(" 4- modificar estudiantes");
                Console.WriteLine();
                Console.WriteLine(" 5- borrar estudiantes");
                Console.WriteLine();
                Console.WriteLine(" 6- imprimir estudiantes");
                Console.WriteLine();
                Console.WriteLine(" 7- salir");
                Console.WriteLine();
                Console.WriteLine(" digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Console.Clear();
                        estudiantes.agregarestudiantes();
                        break;
                    case 2: //vacio por que no lo pidio
                        break;
                    case 3: Console.Clear();
                        estudiantes.consultarestudiantes();
                        break;
                    case 4:Console.Clear();
                        estudiantes.modificarestudiantes();
                        break;
                    case 5: Console.Clear();
                        estudiantes.borrarestudiantes();
                        break;
                    case 6: Console.Clear();
                        estudiantes.imprimirestudiantes();
                        break;
                    default:
                        break;
                }


            } while (opcion !=7);





            Console.ReadLine();
        }
    }
}
