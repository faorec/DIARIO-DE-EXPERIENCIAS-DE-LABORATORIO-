class Program
    {
        static void Main(string[] args)
        {
        string opcion;   
        
        

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  Empleados ");
            Console.WriteLine("Presione 2: ------>  Puestos");
            Console.WriteLine("Presione 3: ------>  Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                string[] nombre = new string[5];
                int[] nacimiento = new int[5];

               for ( int i =0; i< 5; i++)
                {
                    Console.WriteLine("Ingrese nombre de la persona: ");
                    nombre[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese fecha de nacimiento: ");
                    nacimiento[i] = Convert.ToInt32(Console.ReadLine());


                }

               for ( int i=0;i<5; i++ )
                {
                    int edad;
                    edad = 2022 - nacimiento[i];
                    Console.WriteLine(" La edad de "  + nombre[i] + " es de "+ edad);
                }
                break;


                case "2":

                Console.WriteLine(" ");
                int[] salarioPuesto = new int[5];
                string[] Puesto = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el puesto de la persona: ");
                    Puesto[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese el salario del puesto: ");
                    salarioPuesto[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("El puesto de" +Puesto[i] + " y tiene un salario de" + salarioPuesto[i]);
                }
                    
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


