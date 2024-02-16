using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura_de_Datos
{
    internal class Menu
    {
        static int opcion = 0;
        public static void MenuPrincipal()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("***** MENU PRINCIPAL *****");
                Console.WriteLine("1 - Inicializar Arreglos");
                Console.WriteLine("2 - Realizar Pagos");
                Console.WriteLine("3 - Consultar Pagos");
                Console.WriteLine("Elija una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: Pagos.Inicializar();
                        break;
                    case 2: Pagos.RealizarPagos();
                        break;
                    case 3: Pagos.ConsultarPagos();
                        break;
                    case 4:
                        break;
                }
            } while (opcion != 3);
        }
    }
}
