using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_prograII
{
    internal class ClsMenu
    {
        //Atributos
        public int opcion = 0;

        //Metodos
        public static void mostrarmenu() 
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("==================Menu de selección====================");
                Console.WriteLine("Opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Agregar empleados");
                Console.WriteLine("2. Consultar empleado");
                Console.WriteLine("3. Modificar empleado");
                Console.WriteLine("4. Borrar empleado");
                Console.WriteLine("5. Inicializar arreglos");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Calculos salarios");
                Console.WriteLine("8. Salir del programa");
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion) 
                {
                    case 1: Clsempleado.agregar(); break;
                    case 2: Clsempleado.consultar(); break;
                    case 3: submenumod(); break;
                    case 4: Clsempleado.borrar(); break;
                    case 5: Clsempleado.inicializar(); break; 
                    case 6: submenu(); break;
                    case 7: submenucalculoconsalario(); break;
                    default:
                        break;
                }

            } while (opcion != 8);
        }
        public static void submenu() 
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("==================Menu de selección====================");
                Console.WriteLine("Opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Reporte general");
                Console.WriteLine("2. Consulta con filtro");
                Console.WriteLine("3. Salir del programa");
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: Clsempleado.reportegerenral(); break;
                    case 2: Clsempleado.consultar(); break;
                    default:
                        break;
                }

            } while (opcion != 3);
            
        }
        public static void submenumod() 
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("==================Menu de selección====================");
                Console.WriteLine("Opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Cedula");
                Console.WriteLine("2. Nombre");
                Console.WriteLine("3. Direccion");
                Console.WriteLine("4. Telefono");
                Console.WriteLine("5. Salario");
                Console.WriteLine("Ingrese un numero del dato que desea cambiar: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: Clsempleado.modificar(opcion); break;
                    case 2: Clsempleado.modificar(opcion); break;
                    case 3: Clsempleado.modificar(opcion); break;
                    case 4: Clsempleado.modificar(opcion); break;
                    case 5: Clsempleado.modificar(opcion); break;
                    default:
                        break;
                }

            } while (opcion != 3);
        }
        public static void submenucalculoconsalario()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("==================Menu de selección====================");
                Console.WriteLine("Opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Calculo del promedio");
                Console.WriteLine("2. Mayor y menor salario");
                Console.WriteLine("3. Salir del programa");
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: Clsempleado.promediosalarios(); break;
                    case 2: Clsempleado.Mayormenorsalario(); break;
                    default:
                        break;
                }

            } while (opcion != 3);
        }
    }
}
