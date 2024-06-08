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