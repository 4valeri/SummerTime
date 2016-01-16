using System;

class SummerTime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int tapa = n+1  ;
        int taa = (n / 2);

        Console.WriteLine("{0}{1}{0}",
            new string(' ', taa),
            new string('*' , tapa),
            new string(' ', taa));

        int gladka = n - 1;
        int taa2 = (n / 2)+1;

        for (int i = 0; i < taa2; i++)
        {

            Console.WriteLine("{0}*{1}*{0}",
                new string(' ', taa),
                new string(' ', gladka),
                new string(' ', taa));
        }

        int space = (n / 2) - 1;
        int bigspace = n - 1;
        int startplace = (n / 2);


        for (int i = 0; i < space; i++)
        {
            bigspace += 2;
            startplace--;
            Console.WriteLine("{0}*{1}*{0}",
                new string(' ', startplace),
                new string(' ', bigspace),
                new string(' ', taa));
        }

        int dots = (n * 2) - 2;
        int rowDots = n;

        for (int i = 0; i < rowDots; i++)
        {
            Console.WriteLine("*{0}*",
                new string('.', dots));
        }

        int rowsWithA = n;
        int a = (n * 2) - 2;

        for (int i = 0; i < rowsWithA; i++)
        {
            Console.WriteLine("*{0}*",
                new string('@', a));
        }

        int bottom = n * 2;

        Console.WriteLine("{0}", new string('*', bottom));






    }
}

