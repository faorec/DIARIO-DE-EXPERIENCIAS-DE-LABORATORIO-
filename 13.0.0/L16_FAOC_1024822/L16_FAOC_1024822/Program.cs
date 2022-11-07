class Program
{

    public static int[,] operacion = new int[40, 50];

    static void Main(string[] args)
    {

        int suma1 = 0;
        int suma2 = 0;

        Random rnd = new Random();

        for (int i = 0; i < 40; i++)
        {
            for (int x = 0; x < 50; x++)
            {
                operacion[i, x] = rnd.Next(-40, 50);

            }
        }

        for (int i = 0; i < 40; i++)
        {
            for (int x = 0; x < 50; x++)
            {
                if (operacion[i, x] < 0)
                {
                    
                    suma2 = suma2 + operacion[i, x];
                    
                }
            }
        }

        for (int i = 0; i < 40; i++)
        {
            for (int x = 0; x < 50; x++)
            {
                if (operacion[i, x] > 0)
                {
                    
                    suma1 = suma1 + operacion[i, x];
                     
                }
            }
        }

        Console.WriteLine(suma1);
        Console.WriteLine(suma2);
        Console.ReadKey();
    } 
}



