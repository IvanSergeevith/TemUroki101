//using System.Reflection;
//int[] numbers1 = { 1, 2, 3, 4, 5 };
//try
//{
//    // DivideByZeroException
//    int x = 1;
//    int y = 0;
//    Console.WriteLine(x / y);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Ошибка деления на ноль: " + ex.Message);
//}


//try
//{
//    object[] objects = numbers1; // Приведение массива int[] к массиву object[] вызовет ArrayTypeMismatchException
//}
//catch (ArrayTypeMismatchException ex)
//{
//    Console.WriteLine("Несоответствие типа массива: " + ex.Message);
//}

//try
//{
//    int[] numbers = new int[int.MaxValue]; // Попытка создать массив слишком большого размера вызовет OutOfMemoryException
//}
//catch (OutOfMemoryException ex)
//{
//    Console.WriteLine("Произошло исключение OutOfMemoryException: " + ex.Message);
//}

//try
//{
//    // IndexOutOfRangeException
//    int[] array = { 1, 2, 3 };
//    Console.WriteLine(array[3]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Ошибка выхода за границы массива: " + ex.Message);
//}

//try
//{
//    // InvalidCastException
//    object obj = 123;
//    string str = (string)obj;
//}
//catch (InvalidCastException ex)
//{
//    Console.WriteLine("Ошибка недопустимого приведения типов: " + ex.Message);
//}

//// По аналогии можно добавить обработку всех остальных исключений

//Console.ReadLine();

//запрашивает у пользователя список чисел, 
//    вычисляет их сумму и обрабатывает исключение 
//    при некорректном вводе

Console.WriteLine("Введите список чисел, разделенных пробелами:");
string input = Console.ReadLine();

try
{
    string[] numbers = input.Split(' ');
    int sum = 0;

    foreach (string number in numbers)
    {
        if (!int.TryParse(number, out int num))
        {
            throw new FormatException("Некорректный ввод. Пожалуйста, введите только цифры и пробелы.");
        }

        sum += num;
    }

    Console.WriteLine("Сумма введенных чисел: " + sum);
}
catch (FormatException ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}

