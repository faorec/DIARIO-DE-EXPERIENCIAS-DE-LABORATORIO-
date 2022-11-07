using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        string opcion;



        Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
        Console.WriteLine("Presione 1: ------>  Personas");
        Console.WriteLine("Presione 2: ------>  Estudiantes");
        Console.WriteLine("Presione 3: ------>  Salir");

        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                string[] nombre = new string[5];
                int[] edad = new int[5];
                int suma = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese nombre de la persona: ");
                    nombre[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese su edad: ");
                    edad[i] = Convert.ToInt32(Console.ReadLine());

        
                }

                for (int i= 0; i<5; i++)
                {
                    Console.WriteLine("El total de edades ingresadas es de");
                    Console.WriteLine(edad[i]);
                    suma = suma + edad[i];
                }

                Console.WriteLine();
                for (int i=0; i<5; i ++)
                {
                  
                    if (edad[i] >= 18)
                    {
                      
                        Console.WriteLine( "Los mayores de edad son: " + nombre[i] + "de: " + edad[i]);

                    }

                }
                Console.WriteLine("El promedio de edades es de: " + suma / 5);

                break;


            case "2":

                Console.WriteLine(" ");
                string[] nombreapellido = new string[5];
                int[] notas = new int[5];
                nombre = new string[5];
                edad = new int[5];
                int suma2 = 0;


                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el nombre y apellido del estudiante: ");
                    nombreapellido[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese notas del estudiante: ");
                    notas[i] = int.Parse(Console.ReadLine());
                }

               

                for (int i = 0; i < 5; i++)
                {
                    if (notas[i] >= 71)
                    {

                     Console.WriteLine("La notas más alta es de: " + nombreapellido[i] + " con una nota de " + notas[i]);

                    }

                    if (notas[i] <= 71)
                    {

                     Console.WriteLine(" La nota más baja es de: " + nombreapellido[i] + "con una nota de " + notas[i]); 
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                 
                    suma2 = suma2 + notas[i];
                }

                Console.WriteLine("El promedio de notas es de: " + suma2 / 5);

                break;
            case "3":
                Console.WriteLine("Saliendo del programa ,adios.");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Aqui no es ");
                break;

        }
        Console.ReadKey();
    }
}

