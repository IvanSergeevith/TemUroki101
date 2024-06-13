//1
//Создайте вручную папку с домашним заданием.
//Напишите программу, которая просит пользователя ввести путь к файлу и
//текст, который необходимо записать в него.
//После записи вывести на экран информацию “Файл успешно записан”.
//Создать еще 2 файла с названиями “Файл2” и “Файл3” программно
//Вывести на экран содержимое 1го файла.
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Запрос пути к файлу и текста для записи
//        Console.WriteLine("Введите путь к файлу:");
//        string filePath = Console.ReadLine();

//        Console.WriteLine("Введите текст для записи в файл:");
//        string text = Console.ReadLine();

//        // Создание папки и текстового файла вручную
//        string directoryPath = Path.GetDirectoryName(filePath);
//        if (!Directory.Exists(directoryPath))
//        {
//            Directory.CreateDirectory(directoryPath);
//        }

//        File.WriteAllText(filePath, text);

//        Console.WriteLine("Файл успешно записан.");

//        // Создание программно еще двух файлов
//        CreateFile("Файл2.txt", "Содержимое второго файла.");
//        CreateFile("Файл3.txt", "Содержимое третьего файла.");

//        // Вывод содержимого первого файла
//        string contentOfFile1 = File.ReadAllText(filePath);
//        Console.WriteLine($"Содержимое первого файла ({Path.GetFileName(filePath)}):");
//        Console.WriteLine(contentOfFile1);
//    }

//    // Метод для создания файла
//    static void CreateFile(string filePath, string text)
//    {
//        File.WriteAllText(filePath, text);
//        Console.WriteLine($"Файл \"{filePath}\" создан.");
//    }
//}

//2
//Напишите программу, которая просит пользователя ввести путь к файлу на
//компьютере. Затем программа должна проверить, существует ли
//указанный файл, и вывести соответствующее сообщение. Если файл
//существует, программа должна также вывести его размер в байтах, дату
//последнего изменения и расширение файла.

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Запрос пути к файлу
//        Console.WriteLine("Введите путь к файлу:");
//        string filePath = Console.ReadLine();

//        // Проверка существования файла
//        if (File.Exists(filePath))
//        {
//            // Получение информации о файле
//            FileInfo fileInfo = new FileInfo(filePath);

//            // Вывод информации о файле
//            Console.WriteLine($"Файл \"{filePath}\" существует.");
//            Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
//            Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
//            Console.WriteLine($"Расширение файла: {fileInfo.Extension}");
//        }
//        else
//        {
//            Console.WriteLine($"Файл \"{filePath}\" не существует.");
//        }
//    }
//}

//3
//Напишите программу, которая позволяет пользователю перемещаться по
//файловой системе компьютера.
//На экране должна быть видна текущая директория пользователя и под
//этим выводом ожидаться название папки, в которую необходимо перейти.
//После ввода, пользователь переходит в эту папку


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string currentDirectory = Environment.CurrentDirectory;
//        Console.WriteLine("Текущая директория: " + currentDirectory);

//        while (true)
//        {
//            Console.Write("Введите название папки, в которую необходимо перейти (или 'exit' для выхода): ");
//            string input = Console.ReadLine();

//            if (input.ToLower() == "exit")
//            {
//                break;
//            }

//            string newDirectory = System.IO.Path.Combine(currentDirectory, input);

//            if (System.IO.Directory.Exists(newDirectory))
//            {
//                Environment.CurrentDirectory = newDirectory;
//                Console.WriteLine("Перешли в папку: " + newDirectory);
//                currentDirectory = newDirectory;
//            }
//            else
//            {
//                Console.WriteLine("Папка не найдена. Пожалуйста, введите корректное название папки.");
//            }
//        }
//    }
//}

//4

//Напишите программу, которая позволяет пользователю удалить
//файл или папку. Программа должна запрашивать путь к файлу
//или папке, которую нужно удалить, и выполнить удаление. Перед
//удалением, программа должна запрашивать подтверждение
//пользователя.
//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Write("Введите путь к файлу или папке, которую нужно удалить (или 'exit' для выхода): ");
//            string input = Console.ReadLine();

//            if (input.ToLower() == "exit")
//            {
//                break;
//            }

//            if (System.IO.File.Exists(input) || System.IO.Directory.Exists(input))
//            {
//                Console.Write("Вы уверены, что хотите удалить " + input + "? (yes/no): ");
//                string confirmation = Console.ReadLine();

//                if (confirmation.ToLower() == "yes")
//                {
//                    try
//                    {
//                        if (System.IO.File.Exists(input))
//                        {
//                            System.IO.File.Delete(input);
//                            Console.WriteLine("Файл успешно удален.");
//                        }
//                        else if (System.IO.Directory.Exists(input))
//                        {
//                            System.IO.Directory.Delete(input, true);
//                            Console.WriteLine("Папка успешно удалена.");
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine("Ошибка при удалении: " + ex.Message);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Удаление отменено.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Файл или папка не найдены. Пожалуйста, введите корректный путь.");
//            }
//        }
//    }
//}






