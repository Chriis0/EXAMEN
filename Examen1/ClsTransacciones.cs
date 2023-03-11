using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsTransacciones
    {
        public string Numerofactu;
        public string numeroplaca;
        public string fecha;
        public string hora;
        public string tipovehi;

        public List<string> Numerofactura = new List<string>();
        public List<string> NumeroPlaca = new List<string>();
        public List<string> Fecha = new List<string>();
        public List<string> Hora = new List<string>();
        public List<string> TipoVehi = new List<string>();

        public ClsTransacciones() { }
        public ClsTransacciones(string Numerofactu, string numeroplaca, string fecha, string hora, string tipohevi)
        {
            this.Numerofactu = Numerofactu;
            this.numeroplaca = numeroplaca;
            this.fecha = fecha;
            this.hora = hora;
            this.tipovehi = tipohevi;
        }

        public string getNumerofactu()
        { return Numerofactu; }
        public void setNumeroFactu(string Numerofactu)
        { this.Numerofactu = Numerofactu; }

        public string getnumeroplaca()
        { return numeroplaca; }
        public void setnumeroplaca(string numeroplaca)
        { this.numeroplaca = numeroplaca; }

        public string getfecha()
        { return fecha; }
        public void setfecha(string fecha)
        { this.fecha = fecha; }

        public string gethora()
        { return hora; }
        public void sethora(string hora)
        { this.hora = hora; }

        public string gettipovehi()
        { return tipovehi; }
        public void settipovehi(string tipovehi)
        { this.tipovehi = tipovehi; }

        public static void Transacciones()
        {

            int opcionTransacciones = 0;

            do
            {
                Console.WriteLine("1 - Agregar");
                Console.WriteLine("2 - Borrar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4- Reporte");
                Console.WriteLine("5- Salir");
                Console.WriteLine("Digite una opcion");
                opcionTransacciones = int.Parse(Console.ReadLine());

                switch (opcionTransacciones)
                {

                    case 1:
                        Console.WriteLine("1 - Agregar"); ClsTransacciones.IngresarDatos();
                        break;
                    case 2:
                        Console.WriteLine("2 - Consultar"); ClsTransacciones.Consulta();
                        break;
                    case 3:
                        Console.WriteLine("3 - Modificar"); ClsTransacciones.Modificar();
                        break;
                    case 4:
                        Console.WriteLine("4 - Reporte"); ClsTransacciones.Reporte();
                        break;
                    case 5:
                        Console.WriteLine("5- Salir");
                        break;
                    default:
                        break;
                }
            } while (opcionTransacciones != 5);
        }

        public void IngresarDatos()
        {
            void TipoVehiculo()
            {
                int vehiculos = 0;
                do
                {
                    Console.WriteLine("1- Moto");
                    Console.WriteLine("2- Vehículo Liviano");
                    Console.WriteLine("3- Camión");
                    Console.WriteLine("4- AutoBus");
                    Console.WriteLine("5- Salir");
                    vehiculos = int.Parse(Console.ReadLine());

                    switch (vehiculos)
                    {
                        case 1:
                            Console.WriteLine("1- Moto");
                            break;
                        case 2:
                            Console.WriteLine("2- Vehículo Liviano");
                            break;
                        case 3:
                            Console.WriteLine("3- Camión");
                            break;
                        case 4:
                            Console.WriteLine("4- AutoBus");
                            break;
                        case 5:
                            Console.WriteLine("5- Salir");
                            break;
                        default:
                            break;
                    }
                } while (vehiculos != 5);
            }

            void Casetas()
            {
                int caseta = 0;
                do
                {
                    Console.WriteLine("1- Caseta 1");
                    Console.WriteLine("2- Caseta 2");
                    Console.WriteLine("3- Caseta 3");
                    Console.WriteLine("4- Salir");
                    caseta = int.Parse(Console.ReadLine());

                    switch (caseta)
                    {
                        case 1:
                            Console.WriteLine("1- Caseta 1");
                            break;
                        case 2:
                            Console.WriteLine("2- Caseta 2");
                            break;
                        case 3:
                            Console.WriteLine("3- Caseta 3");
                            break;
                        case 4:
                            Console.WriteLine("4- Salir");
                            break;
                        default:
                            break;
                    }
                } while (caseta != 4);
            }
            void montoPagar()
            {
                float pagar = 0;
                do
                {
                    
                    Console.WriteLine("1- Vehículo liviano ¢700");
                    Console.WriteLine("2- Camión o Pesado ¢2700");
                    Console.WriteLine("3- Motocicleta ¢500");
                    Console.WriteLine("4- Autobús ¢3700");
                    Console.WriteLine("5- Salir");
                    pagar = float.Parse(Console.ReadLine());

                    switch (pagar)
                    {
                        case 1:
                            Console.WriteLine("1- Vehículo liviano ¢700");
                            break;
                        case 2:
                            Console.WriteLine("2- Camión o Pesado ¢2700");
                            break;
                        case 3:
                            Console.WriteLine("3- Motocicleta ¢500");
                            break;
                        case 4:
                            Console.WriteLine("4- Autobús ¢3700");
                            break;
                        case 5:
                            Console.WriteLine("5- Salir");
                            break;
                        default:
                            break;
                    }
                } while (pagar != 5);
            }

            ClsTransacciones clsTransacciones = new ClsTransacciones();

            int i = Numerofactu.Count();

            Console.WriteLine("Flujo de Datos");
            bool mer = true;

            do
            {
                if (i < 15)
            {

                Console.Write("Ingrese el número de factura:  ");
                string factu = Console.ReadLine();
                clsTransacciones.Numerofactu = factu;

                Console.Write("Ingrese el número de placa:  ");
                string placa = Console.ReadLine();
                clsTransacciones.numeroplaca = placa;

                Console.Write("Ingrese la fecha:  ");
                string fechap = Console.ReadLine();
                clsTransacciones.fecha = fechap;

                Console.Write("Ingrese la hora:  ");
                string horap = Console.ReadLine();
                clsTransacciones.hora = horap;

                Console.Write("Ingrese el tipo de vehiculo:  ");
                string tipo = Console.ReadLine();
                clsTransacciones.tipovehi = tipo;
                int vehiculop = int.Parse(Console.ReadLine());

                Numerofactura.Add(clsTransacciones.getNumerofactu());
                NumeroPlaca.Add(clsTransacciones.getnumeroplaca());
                Fecha.Add(clsTransacciones.getfecha());
                Hora.Add(clsTransacciones.gethora());
                TipoVehi.Add(clsTransacciones.gettipovehi());
            }
            else
            {
                Console.WriteLine("Cantidad máxima de datos ingresados");

            }
            return;
        
            Console.Write("¿Desea agregar otro producto?  s/n");

            string lit = Console.ReadLine();

            if (lit.Equals("n"))
            {
                mer = false;
                return;
            }


        } while (mer == true);

        }

        public void Consulta() 
        {
            int cantidad = Numerofactura.Contains;

            Console.WriteLine("Consultar lista de datos de Vehículos: ");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Número de Factura:  " + Numerofactura[i]);
                Console.WriteLine("Número de Placa:  " + numeroplaca[i]);
                Console.WriteLine("Fecha:  " + fecha[i]);
                Console.WriteLine("Hora:  " + hora[i]);
                Console.WriteLine("Tipo de Vehículo: "  + tipovehi[i]);
                Console.WriteLine("******");
            }
            return;
        }

        public  void Modificar()  
        {
            Console.WriteLine("Modificar Datos");
            bool mer = true;
            do
            {
                int cantidad = Numerofactu.Count;

                Console.WriteLine("Ingrese el número de factura que desea modificar :  ");

                string name = Console.ReadLine();
                int bora = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (Numerofactu[i].Equals(name))
                    {
                        bora = i;
                    }
                }

                NumeroPlaca.RemoveAt(bora);
                tipovehi.RemoveAt(bora);

                Console.Write("¿Desea modificar otro producto?  S/N");

                string lit = Console.ReadLine();

                if (lit.Equals("n"))
                {
                    mer = false;
                    return;
                }


            } while (mer == true);
        }

        public void Reporte()
        {

            Console.WriteLine("Los número de factura son:  ");
            Console.WriteLine("Los número de placa son:  ");
            Console.WriteLine("Las fechas son:  ");
            Console.WriteLine("Las horas son:  ");
            Console.WriteLine("Los tipos de vehículos son:  ");
            ClsTransacciones.Transacciones();

        }
    }
}
