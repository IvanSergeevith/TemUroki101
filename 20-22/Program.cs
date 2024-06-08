class Program
{
    static int[,] Mass()
    {
        Random rnd = new Random();
        int[,] mass = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mass[i, j] = rnd.Next(-50, 51);
            }
        }

        return mass;
    }

    static int[,] SumMass(int[,] mass1, int[,] mass2)
    {
        int[,] sumMass = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                sumMass[i, j] = mass1[i, j] + mass2[i, j];
            }
        }

        return sumMass;
    }

    static int MasMax(int[,] array)
    {
        int max = array[0, 0];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        return max;
    }

    static void PrintMas(int[,] mas3)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(mas3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] mas1 = Mass();
        int[,] mas2 = Mass();

        Console.WriteLine("Первый массив:");
        PrintMas(mas1);
        Console.WriteLine("Второй массив:");
        PrintMas(mas2);

        int[,] sumMass = SumMass(mas1, mas2);
        Console.WriteLine("Сумма массивов:");
        PrintMas(sumMass);

        int max1 = MasMax(mas1);
        int max2 = MasMax(mas2);

        Console.WriteLine($"Максимальное значение в первом массиве: {max1}" +
            $"\nМаксимальное значение во втором массиве: {max2}");
    }


}