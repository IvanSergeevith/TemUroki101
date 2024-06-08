Console.WriteLine($"Правила." +
    $"\n 1. Автоматически бросается 2 кубика." +
    $"\n 2. Cделаете прямоугольник со сторонами с помошью сгенирированных чисел." +
    $"\n 3. Прямоугольник должен быть присоеденен к вашей существующей территории." +
    $"\n 4. Первыйпрямоугольник игрока помещается в угол, а второй в угол противоположный первому по диагонали." +
    $"\n 5. Если вы не можите сделать сгенерированный прямоугольник, то вы пропускаете ход." +
    $"\n 6. Игра считается окончиной когда все пространство заполнено." +
    $"\n 7. Побеждает тот игрок у кого большаяя территория." +
    $"\n Enter - начать игру!");
Console.ForegroundColor = ConsoleColor.White;



//Это наше поле...
int[,] Field = new int[25, 25];
Random random = new Random();

for (int i = 0; i < 25; i++)
{
    for (int j = 0; j < 25; j++)
    {
        Field[i, j] = 0;
    }
}

string player1 = "[]";
string player2 = "<>";
string field = "--";

FieldOut(Field, player1, player2, field);

Console.ReadKey();
//очередность хода
int round = 2;
do
{
    if (round == 1)
        round++;
    else round = 1;

    int x = random.Next(1, 7), y = random.Next(1, 7);
    InterfaceMove(round, x, y, Field, player1, player2, field);
    Console.ReadKey();

} while (true);

//Бросание кубика
static void InterfaceMove(int move, int x, int y, int[,] F, string p1, string p2, string f)
{
    int x1, y1;
    Console.Clear();

    FieldOut(F, p1, p2, f);
    Console.WriteLine("Бросок кубиков: " + x + ", и " + y);

    Console.Write("Место в: \nx (вертикальный): ");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y (горизонтальный): ");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (move == 1)
        for (int i = x1; i < x1 + x; i++)
        {
            for (int j = y1; j < y1 + y; j++)
            {
                F[i, j] = move;
            }
        }
    else if (move == 2)
        for (int i = x1; i < x1 + x; i++)
        {
            for (int j = y1; j < y1 + y; j++)
            {
                F[24 - i, 24 - j] = move;
            }
        }
}
//результат выведения на консоль 
static void FieldOut(int[,] F, string p1, string p2, string f)
{
    for (int i = 0; i < 27; i++)
    {
        for (int j = 0; j < 27; j++)
        {
            if (i == 0 && j == 0)
                Console.Write("   ");
            else if (i == 0 && j < 11)
                Console.Write(j - 1 + " ");
            else if (i == 0 && j == 26)
                Console.Write("");
            else if (i < 11 && j == 0)
                Console.Write(" " + (i - 1) + " ");
            else if (i < 11 && j == 26)
                Console.Write(" " + (25 - i));
            else if (i == 26 && j == 26)
                Console.Write("  ");
            else if (j == 26)
                Console.Write(" " + (25 - i));
            else if (i == 26 && j == 0)
                Console.Write("   ");
            else if (i == 26 && (25 - j) > 9)
                Console.Write(25 - j);
            else if (i == 26 && j != 0)
                Console.Write(" " + (25 - j));
            else if (i == 0)
                Console.Write(j - 1);
            else if (j == 0)
                Console.Write((i - 1) + " ");

            else
            {
                if (F[i - 1, j - 1] == 0)
                    Console.Write(f);
                else if (F[i - 1, j - 1] == 1)

                    Console.Write(p1);
                else if (F[i - 1, j - 1] == 2)
                    Console.Write(p2);
            }
        }
        Console.WriteLine();
    }
}