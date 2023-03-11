using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Clsmenu
    {
        public static ClsTransacciones clsTransacciones = new ClsTransacciones();
        public static void menuprincipal()
        {

            byte opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Ingresar Paso Vehcular");
                Console.WriteLine("3- Consulta de vehículos x Número de Placa");
                Console.WriteLine("4- Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("5- Reporte Todos los Datos de los vectores");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1- Inicializar Vectores");
                        break;
                    case 2:
                        Console.WriteLine("2- Ingresar Paso Vehcular");
                        break;
                    case 3:
                        Console.WriteLine("3- Consulta de vehículos x Número de Placa");
                        break;
                    case 4:
                        Console.WriteLine("4- Modificar Datos Vehículos x número de Placa");
                        break;
                    case 5:
                        Console.WriteLine("5- Reporte Todos los Datos de los vectores");
                        break;
                    case 6:
                        Console.WriteLine("6- Salir");
                        break;
                    default:
                        break;
                }

            } while (opcion != 6);
        }

        public void InicializarVectores()
        {

        }

        public void IngresarDatos()
        {

        }
    }
}
