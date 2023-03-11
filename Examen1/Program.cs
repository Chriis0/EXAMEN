using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clsmenu clsmenu = new Clsmenu();
            Clsmenu.menuprincipal();

            ClsTransacciones clsTransacciones = new ClsTransacciones();
            ClsTransacciones.Transacciones();
            ClsTransacciones.Reporte();
        }
    }
}
