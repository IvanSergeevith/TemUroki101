//Напишите функцию, которая принимает два числа и выводит на экран их
//сумму.
//Числа передаются пользователем в переменные, которые затем
//передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится
//на консоль.
//class Program
//{
//    int Sum(int summand_1, int summand_2)
//    {
//        return summand_1 + summand_2;
//    }

//    void Main(string[] args)
//    {
//        int a, b, c;

//        a = int.Parse(Console.ReadLine());
//        b = int.Parse(Console.ReadLine());
//        c = Sum(a, b);
//        Console.WriteLine(c);

//    }
//}

//Напишите функцию, которая принимает массив целых чисел и возвращает
//среднее значение элементов массива.
//Массив задать явно
//Функция должна возвращать результат, который в последствии выводится
//на консоль.

//class Program
//{
//    static double Arithmetic(int[] numbers)
//    {
//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }

//        return (double)sum / numbers.Length;
//    }

//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        double average = Arithmetic(numbers);
//        Console.WriteLine("Среднее арифметическое: " + average);
//    }
//}


//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата
//новый массив суммы.
//2. Поиска максимального значения массива.

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



