class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        int[] edad = new int [5];
        string[] nombre = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese Nombre de persona: ");
            nombre[i] =Console.ReadLine();

            Console.WriteLine("Ingrese Edad de la persona : ");
            edad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los mayores de edad y sus edades son:");

        for ( int i =0; i < 5; i++)
        {
            if( edad[i] >= 18)
            {
                Console.WriteLine(nombre[i] + ", " + edad[i]);
               
            }


        }

        Console.ReadKey();
    }
    

    
    
}

