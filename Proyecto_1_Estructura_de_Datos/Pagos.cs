using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura_de_Datos
{
    internal class Pagos
    {
        static int posicion = 1;
        static byte indice = 0;
        static int cant = 2;
        static int [] numero_de_pago = new int [cant];
        static Random aleatorio = new Random ();
        static string[] fecha = new string[cant];
        static int[] hora = new int[cant];
        static int[] cedula = new int[cant];
        static string [] nombre = new string[cant];
        static string[] apellido1 = new string[cant];
        static string[] apellido2 = new string[cant];
        static int[] numero_de_caja = new int[cant];
        static int[] tipo_de_servicio = new int[cant];
        static int[] numero_factura = new int[cant];
        static double[] monto_a_pagar = new double[cant];
        static double[]monto_comision = new double [cant];
        static double []monto_deducido = new double[cant];
        static double[] monto_paga_cliente = new double[cant];
        static double[] vuelto = new double[cant];
        static char respuesta = ' ';
        static int consulta_numero_pago = 0;

        //******************MENU PRINCIPAL*******************
        public static void Inicializar() 
        {
            numero_de_pago = Enumerable.Repeat(0, cant).ToArray();
            fecha = Enumerable.Repeat("", cant).ToArray();
            hora = Enumerable.Repeat(0, cant).ToArray();
            cedula = Enumerable.Repeat(0, cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            apellido1 = Enumerable.Repeat("", cant).ToArray();
            apellido2 = Enumerable.Repeat("", cant).ToArray();
            numero_de_caja = Enumerable.Repeat(0, cant).ToArray();
            tipo_de_servicio = Enumerable.Repeat(0, cant).ToArray();
            numero_factura = Enumerable.Repeat(0, cant).ToArray();
            monto_a_pagar = Enumerable.Repeat(0d, cant).ToArray();
            monto_comision = Enumerable.Repeat(0d, cant).ToArray();
            monto_deducido = Enumerable.Repeat(0d, cant).ToArray();
            vuelto = Enumerable.Repeat(0d, cant).ToArray();
            monto_paga_cliente = Enumerable.Repeat(0d, cant).ToArray();
            posicion = 1;
            indice = 0;
            Console.Clear();
            Console.WriteLine("***** ARREGLOS INICIALIZADOS *****");
            Console.ReadLine();
        
        }
        public static void RealizarPagos()
        { 
            
            do
            {
                for (int i = 0; i < cant; i++)
                {
                    numero_de_pago[i] = aleatorio.Next(1, 10);
                }
                for (int i = 0; i < cant; i++)
                {
                    numero_de_caja[i] = aleatorio.Next(1, 3);
                }

                Console.WriteLine($"Digite la fecha ({posicion}): ");
                fecha[indice] = Console.ReadLine();
                Console.WriteLine($"Digite la hora ({posicion}): ");
                hora[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite la cedula ({posicion}): ");
                cedula[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite el nombre ({posicion}): ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el primer apellido ({posicion}): ");
                apellido1[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el segundo apellido ({posicion}): ");
                apellido2[indice] = Console.ReadLine();
                Console.WriteLine("Elija el servicio a pagar: \n1-Electricidad \n2-Telefono \n3-Agua");
                tipo_de_servicio[indice] = int.Parse(Console.ReadLine());
                if (tipo_de_servicio[indice] == 1 || tipo_de_servicio[indice] == 2 || tipo_de_servicio[indice] == 3)
                {
                    Console.WriteLine("Opcion correcta");
                }
                else
                {
                    Console.WriteLine("Seleccion fuera de rango. Por favor, elija 1, 2 o 3.");
                }
                Console.WriteLine($"Digite el numero de factura ({posicion}): ");
                numero_factura[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite el monto a pagar ({posicion}): ");
                monto_a_pagar[indice] = int.Parse(Console.ReadLine());
                if (tipo_de_servicio[indice] == 1)
                    {
                    monto_comision[indice] = (monto_a_pagar[indice] * 0.04);
                    monto_deducido[indice] = monto_a_pagar[indice] - monto_comision[indice];
                    }
                else if (tipo_de_servicio[indice] == 2)
                    {
                    monto_comision[indice] = (monto_a_pagar[indice] * 0.055);
                    monto_deducido[indice] = monto_a_pagar[indice] - monto_comision[indice];
                    }
                else if (tipo_de_servicio[indice] == 3)
                    {
                    monto_comision[indice] = (monto_a_pagar[indice] * 0.065);
                    monto_deducido[indice] = monto_a_pagar[indice] - monto_comision[indice];
                    }
                Console.WriteLine($"Con cuanto paga? ({posicion}): ");
                monto_paga_cliente[indice] = int.Parse(Console.ReadLine());
                vuelto[indice] = monto_paga_cliente[indice] - monto_a_pagar[indice];
                indice++;
                posicion++;

                Console.WriteLine($"\n\n                       Sistema Pago de Servicios Publicos \n                      Tienda La Favorita - Ingreso de Datos \n\n ");
                
                for (int i = 0; i < indice; i++)
                {
                Console.WriteLine($"Numero de pago: {numero_de_pago[i]}\nFecha: {fecha[i]}           Hora:{hora[i]} \n\nCedula: {cedula[i]}                       Nombre: {nombre[i]}\nApellido1: {apellido1[i]}                            Apellido2: {apellido2[i]}\n\nTipo de Servicio:  {tipo_de_servicio[i]}                   [1-Electricidad 2-Telefono 3-Agua]\n\nNumero de Factura: {numero_factura[i]}                  Monto Pagar: {monto_a_pagar[i]}\nComision autorizada: {monto_comision[i]}                          Paga con: {monto_paga_cliente[i]}\nMonto deducido: {monto_deducido[i]}                            Vuelto: {vuelto[i]} ");
                }
                Console.WriteLine("\n\n                   Desea realizar otro pago? S/N");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            } while (respuesta != 'N');

            Console.Read();


        }
        public static void ConsultarPagos()
        {
          do
          { 

            Console.WriteLine("                         Sistema Pago de Servicios Publicos\n                        Tienda La Favorita - Consulta de Datos\n\n");
            Console.WriteLine("Numero de Pago: ");
            consulta_numero_pago = int.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < cant; i++)
            {
                if (consulta_numero_pago == numero_de_pago[i])
                {
                    encontrado = true;

                    Console.WriteLine($"Numero de pago: {numero_de_pago[i]}\nFecha: {fecha[i]}           Hora:{hora[i]} \n\nCedula: {cedula[i]}                       Nombre: {nombre[i]}\nApellido1: {apellido1[i]}                            Apellido2: {apellido2[i]}\n\nTipo de Servicio:  {tipo_de_servicio[i]}                   [1-Electricidad 2-Telefono 3-Agua]\n\nNumero de Factura: {numero_factura[i]}                  Monto Pagar: {monto_a_pagar[i]}\nComision autorizada: {monto_comision[i]}                          Paga con: {monto_paga_cliente[i]}\nMonto deducido: {monto_deducido[i]}                            Vuelto: {vuelto[i]} ");
                }  
            }
              Console.WriteLine("\n\n                   Desea consultar otro pago? S/N");
              respuesta = char.Parse(Console.ReadLine().ToUpper());
              Console.Clear();
          } while (respuesta != 'N');
            


        }
    }
}
