using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class estudiantes
    {
        //prop

        // get return de un valor
        // set para asignar un valor
        //delimitadores de accesos: public, private,  protected

    
        private static string[] nombre = new string[3];
        private static byte[] edad = new byte[3];

        private static float[] notas = new float[3];

        private static byte indice = 0;


        public static void agregarestudiantes()
        {
            char opcion2 = 'n';
            try
            {
                do
                {
                    Console.WriteLine("Ingrese al estudiante {0}:", (indice + 1));
                    nombre[indice] = Console.ReadLine();

                    Console.WriteLine("ingrese la edad");
                    edad[indice] = byte.Parse(Console.ReadLine());
                    indice++;

                    Console.WriteLine("quiere agregar otro estudiante(s/n)");
                    opcion2 = Convert.ToChar(Console.ReadLine().ToLower());

                    Console.Clear();
                } while (!opcion2.Equals('n')); //esto dice "mientras opcion 2 sea diferente a "n" va a continuar
            }
            catch (Exception error)
            {
                Console.WriteLine("no digito ningun valor,       "+ error);
                Console.Read();
            }
        }






        //no nos pidio el "agregar notas", a lo que yo recuerdo






        public static void consultarestudiantes()
        {
            Console.WriteLine("Digite el nombre: ");
            string nombrebuscar = Console.ReadLine();
            
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i].Equals(nombrebuscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"El estudiante existe y tiene {edad[i]} años.");
 
                    break;
                }
            }
            Console.WriteLine("No se encontró al estudiante.");
        }

        public static void borrarestudiantes()
        {
            Console.WriteLine("digite el nombre del estudiante que desea eliminar");
            string buscarnombre2 = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i].Equals(buscarnombre2, StringComparison.OrdinalIgnoreCase))
                {
                    nombre[i] = "";
                    edad[i] = 0;

                    Console.WriteLine("se a borrado el estudiante");
                    return;
                }
            }
        }

        public static void modificarestudiantes()
        {
            Console.WriteLine("digite el nombre que desea modificar");
            string buscarnombre3 = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i].Equals(buscarnombre3, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"el nombre {nombre[i]} sera modificado por: ");
                    nombre[i] = Console.ReadLine();
                    
                    Console.WriteLine($"y su edad {edad[i]} sera modificada por: ");
                    edad[i] = byte.Parse(Console.ReadLine());
 ;
                    return;
                }
            }
        }

        public static void imprimirestudiantes()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("nombre             edad");
            Console.WriteLine("-----------------------");
            Console.ForegroundColor= ConsoleColor.White;

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"{nombre[i]}             {edad[i]}");
            }
        } 
    }
}
