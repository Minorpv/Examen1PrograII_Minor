using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_prograII
{
    internal class Clsempleado
    {
        //Atributos
        static int cant = 10;
        static byte indice = 0;
        static byte posicion = 1;
        private static string[] cedula = new string[cant];
        private static string[] nombre = new string[cant];
        private static string[] direccion = new string[cant];
        private static string[] telefono = new string[cant];
        private static float[] salario = new float[cant];

        //Metodos

        public static void agregar()
        {
            char respuesta = 'S';
            do
            {
                //Ingreso de datos
                Console.WriteLine($"Digite la cedula {posicion}: ");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el nombre {posicion}: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine($"Digite la direccion {posicion}: ");
                direccion[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el telefono {posicion}: ");
                telefono[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el salario {posicion}: ");
                float.TryParse(Console.ReadLine(), out salario[indice]);
                indice++;
                posicion++;
                //Opcion para continuar en el bucle
                Console.WriteLine("Desea ingresar otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            } while ((respuesta != 'N') && (posicion < cant));

            
        }
        public static void consultar()
        {
            Console.Clear();
            Console.WriteLine($"Digite la cedula a consultar: ");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < posicion; i++) 
            {
                if (ced.Equals(cedula[i])) 
                {
                    //print de los datos consultados
                    Console.WriteLine($"Cedula: {cedula[i]}  Nombre: {nombre[i]}");
                    Console.WriteLine($"Direccion: {direccion[i]}   Telefono: {telefono[i]}   Salario: {salario[i]}");
                    existe = true;
                }
                if (!existe) 
                {
                    Console.WriteLine("El empleado no existe");
                }
            }
        }
        public static void modificar(int seleccion)
        {
            //movimiento al metodo para modificar el elemento
            if (seleccion == 1)
            {
                modcedula(seleccion);
            }
            else if (seleccion == 2)
            {
                modnombre(seleccion);
            }
            else if (seleccion == 3)
            {
                moddireccion(seleccion);
            }
            else if (seleccion == 4)
            {
                modtelefono(seleccion);
            }
            else modsalario(seleccion);
        }
        public static void modcedula(int seleccion) 
        {
            char respuesta = 'S';
            while (respuesta == 'S') 
            {
                Console.Clear();
                int ced = 0;
                int newced = 0;
                Console.WriteLine($"Digite la cedula a modificar: ");
                ced = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor nuevo de la cedula:");

                //Se verifica que los espacios esten vacios en la nueva cedula para luego agregarla
                if (nombre[newced] == "")
                {
                    if (direccion[newced] == "")
                    {
                        if (telefono[newced] == "")
                        {
                            if (salario[newced] == 0)
                            {
                                cedula[newced] = Console.ReadLine();
                                Console.WriteLine("Cedula actualizada");
                            }
                        }
                    }
                }
                //EN casi de que ya se est[e usando para otro empleado no se hace el cambio
                else Console.WriteLine("Esa cedula ya se esta usando");
                Console.WriteLine("Desea modificar otro dato otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            }
            

        }
        public static void modnombre(int seleccion)
        {
            Console.Clear();
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                int nomb = 0;
                int newnomb = 0;
                Console.WriteLine($"Digite la cedula a modificar: ");
                nomb = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor nuevo del nombre:");
                cedula[newnomb] = Console.ReadLine();
                Console.WriteLine("Nombre actualizado");
                Console.WriteLine("Desea modificar otro dato otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            }
        }
        public static void moddireccion(int seleccion)
        {
            Console.Clear();
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                int direccion = 0;
                int newdireccion = 0;
                Console.WriteLine($"Digite la cedula a modificar: ");
                direccion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor nuevo de la direccion:");
                cedula[newdireccion] = Console.ReadLine();
                Console.WriteLine("Direccion actualizada");
                Console.WriteLine("Desea modificar otro dato otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            }
        }
        public static void modtelefono(int seleccion)
        {
            Console.Clear();
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                int tel = 0;
                int newtel = 0;
                Console.WriteLine($"Digite la cedula a modificar: ");
                tel = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor nuevo del numero de telefono:");
                cedula[newtel] = Console.ReadLine();
                Console.WriteLine("Telefono actualizado");
                Console.WriteLine("Desea modificar otro dato otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            }
        }
        public static void modsalario(int seleccion) 
        {
            Console.Clear();
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                int sal = 0;
                int newsal = 0;
                Console.WriteLine($"Digite la cedula a modificar: ");
                sal = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor nuevo del salario:");
                cedula[newsal] = Console.ReadLine();
                Console.WriteLine("Salario actualizado");
                Console.WriteLine("Desea modificar otro dato otro empleado (S/N): ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            }
        }
        public static void borrar()
        {
            Console.Clear();
            Console.WriteLine($"Digite el nombre del empleado a eliminar: ");
            string nomb = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < posicion; i++)
            {
                if (nomb.Equals(nombre[i]))
                {
                    cedula[i] = " ";
                    nombre[i] = " ";
                    direccion[i] = " ";
                    telefono[i] = " ";
                    salario[i] = 0;
                    existe = true;
                }
                if (existe != true)
                {
                    Console.WriteLine("El empleado no existe");
                }
            }
        }
        public static void inicializar()
        {
            //Se reinician  todos los arreglos
            cedula = Enumerable.Repeat("", cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            direccion = Enumerable.Repeat("", cant).ToArray();
            telefono = Enumerable.Repeat("", cant).ToArray();
            salario = Enumerable.Repeat(0f, cant).ToArray();
            Console.Clear();
            Console.WriteLine("Arreglos inicializados");
            Console.ReadLine();
        }
        public static void reportegerenral()
        {
            //Imprime todos los datos
            Console.WriteLine("====================Reporte general======================");
            for (int i = 0; i < posicion; i++) 
            {
                Console.WriteLine($"Cedula: {cedula[i]}  Nombre: {nombre[i]}");
                Console.WriteLine($"Direccion: {direccion[i]}   Telefono: {telefono[i]}   Salario: {salario[i]}");
            }
            Console.WriteLine("====================Fin del reporte====================");
            Console.ReadLine() ;
            Console.Clear() ;
        }
        public static void promediosalarios() 
        {
            float acum = 0f;
            float promedio = 0f;
            // EN todas las posiciones ya registradas se acumulan para luego dividirlo entre la cantidad de posiciones
            for (int i = 0; i < posicion; i++) 
            { 
                acum = salario[i]+acum;
            }
            promedio = acum/posicion;
            Console.WriteLine($"El promedio de salarios es de: {promedio}");
            Console.ReadLine();
        }
        public static void Mayormenorsalario()
        {
            float mayor = 0f;
            float menor = 0f;
            for (int i = 0; i < posicion; i++) 
            {
                if (salario[i] > mayor) 
                { 
                    mayor = salario[i];
                }
                if (i == 1)
                {
                    menor = mayor;
                }
                else if (salario[i] < menor) 
                {
                    menor = salario[i];
                }


            }
            Console.WriteLine($"El salario mayor es {mayor} y el menor es {menor}]");
            Console.ReadLine();
        }

    }
}
