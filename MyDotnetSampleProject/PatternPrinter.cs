using System;

public class PatternPrinter
{
    public void Pattern()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                if (j == 6 || j == 5)
                {
                    continue;
                }
                Console.Write(" " + j + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }


        for (int i = 0; i < 5; i++)
        {
            int k = (i == 2) ? 2 : 0;

            for (int j = (i == 4 ? 0 : 10); j != (i == 4 ? 11 : k); j += (i == 4 ? 1 : -1))
            {
                if (i == 4 && j == 8)
                    continue;
                Console.Write(" " + j + " ");
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }

}
