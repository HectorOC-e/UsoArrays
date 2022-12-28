using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;

            //edades = new int[4];

            //edades[0] = 15;
            //edades[1] = 27;
            //edades[2] = 19;
            //edades[3] = 80;

            //int[] edades = { 15, 27, 19, 80 };
            //Console.WriteLine(edades[2]);

            // array implícito 
            //var datos = new[] { "Juan", "Díaz", "España" };
            //var valores = new[] { 15,28,35,75.5, 30.30 };

            // arrays de objetos
            //Empleados[] arrayEmpleados = new Empleados[2];
            //Empleados ana = new Empleados("Ana",27);

            //arrayEmpleados[0] = new Empleados("Sara", 37);
            //arrayEmpleados[1] = ana;

            // array de tipos o clases anónimas

            //var Personas = new[]
            //{
            //    new{Nombre = "Juan", Edad = 19 },
            //    new{ Nombre = "María", Edad = 49},
            //    new{ Nombre = "Diana", Edad = 35}
            //};

            //for (int i = 0; i < arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine($"{arrayEmpleados[i].GetInfo()}\n");
            //}

            //foreach (var persona in Personas)
            //{
            //    Console.WriteLine(persona);
            //}

            //int[] numeros = new int[4];

            //numeros[0] = 7;
            //numeros[1] = 9;
            //numeros[2] = 15;
            //numeros[3] = 3;

            //ProcesaDatos(numeros);

            //foreach (int item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            int [] arrayElementos = LeerDatos();

            foreach (int item in arrayElementos) Console.WriteLine(item);
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion [{i}]: ");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;

            }

            return datos;
        }

        //static void ProcesaDatos(int[] datos)
        //{
        //    //foreach (int item in datos)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}

        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        datos[i] += 10;
        //    }
        //}

    }



    //class Empleados
    //{
    //    private string nombre;
    //    private int edad;

    //    public Empleados(String nombre, int edad) 
    //    {
    //        this.nombre = nombre;
    //        this.edad = edad;
    //    }

    //    public string GetInfo() => $"Nombre del empleado: {this.nombre} Edad: {this.edad}";
    //}
}
