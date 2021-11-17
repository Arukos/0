using System;
using System.Collections;

namespace _0x
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            const int N = 9;
            string a = "Крестики", b = "Нолики";
            string s;
            int x, y;
            Random rnd = new Random();
            for (int i = 1; i <= N + 1; i++)
            {
                list.Add("?");
            }
            Print(list);
            Console.WriteLine("1)Человек & Человек" +
                              "2)Человек & Компьютер");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                for (int i = 1; i <= N; i++)
                {

                    Console.Write("Сделайте свой ход ");
                    if (!(i % 2 == 0))
                    {
                        s = a;
                        Console.WriteLine(s);
                    }
                    else
                    {
                        s = b;
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("Столбец(1-3)");
                    string w = Console.ReadLine();
                    x = int.Parse(w);

                    Console.WriteLine("Строку(1-3)");
                    w = Console.ReadLine();
                    y = int.Parse(w);
                    if (s == a)
                    {
                        if (y == 2) x += 3;
                        if (y == 3) x += 6;
                        x = CheckPlace(list, x);
                        list[x] = "x";

                    }
                    else
                    {
                        if (y == 2) x += 3;
                        if (y == 3) x += 6;
                        x = CheckPlace(list, x);
                        list[x] = "O";
                    }
                    Print(list);
                    if (CheckWin(list) == 1)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Сделайте выбор 1)крестики 2)нолики");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    for (int i = 1; i <= N; i++)
                    {

                        Console.Write("Сделайте свой ход ");
                        if (!(i % 2 == 0))
                        {
                            s = a;
                            Console.WriteLine(s);
                            Console.WriteLine("Столбец(1-3)");
                            string w = Console.ReadLine();
                            x = int.Parse(w);

                            Console.WriteLine("Строку(1-3)");
                            w = Console.ReadLine();
                            y = int.Parse(w);
                        }
                        else
                        {
                            s = b;
                            Console.WriteLine(s);
                            x = rnd.Next(1, 4);
                            y = rnd.Next(1, 4);
                        }


                        if (s == a)
                        {
                            if (y == 2) x += 3;
                            if (y == 3) x += 6;
                            x = CheckPlace(list, x);
                            list[x] = "x";

                        }
                        else
                        {
                            if (y == 2) x += 3;
                            if (y == 3) x += 6;
                            x = CheckPlaceBot(list, x);
                            list[x] = "O";
                        }
                        Print(list);
                        if (CheckWin(list) == 1)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= N; i++)
                    {

                        Console.Write("Сделайте свой ход ");
                        if (!(i % 2 == 0))
                        {
                            s = a;
                            Console.WriteLine(s);
                            x = rnd.Next(1, 4);
                            y = rnd.Next(1, 4);
                        }
                        else
                        {
                            s = b;
                            Console.WriteLine(s);
                            Console.WriteLine("Столбец(1-3)");
                            string w = Console.ReadLine();
                            x = int.Parse(w);

                            Console.WriteLine("Строку(1-3)");
                            w = Console.ReadLine();
                            y = int.Parse(w);
                        }


                        if (s == a)
                        {
                            if (y == 2) x += 3;
                            if (y == 3) x += 6;
                            x = CheckPlaceBot(list, x);
                            list[x] = "x";

                        }
                        else
                        {
                            if (y == 2) x += 3;
                            if (y == 3) x += 6;
                            x = CheckPlace(list, x);
                            list[x] = "O";
                        }
                        Print(list);
                        if (CheckWin(list) == 1)
                        {
                            break;
                        }
                    }
                }
            }
            static void Print(ArrayList lw)
            {
                int N = 9, k = 1;
                for (int i = 1; i <= N; i++)
                {
                    if (!(i % 3 == 0))
                    {
                        Console.Write(lw[i]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine(lw[i]);
                        Console.WriteLine(" ");

                        k++;
                    }
                }
            }
            static int CheckPlace(ArrayList list, int x)
            {
                Boolean a = true;
                while (a)
                {
                    if (list[x] != "?")
                    {
                        Console.WriteLine("Место занято попробуй ещё раз");
                        Console.WriteLine("Строку(1-3)");
                        string w = Console.ReadLine();
                        x = int.Parse(w);

                        Console.WriteLine("Столбец(1-3)");
                        w = Console.ReadLine();
                        int y = int.Parse(w);
                        if (y == 2) x += 3;
                        if (y == 3) x += 6;
                    }
                    else
                    {
                        a = false;
                    }
                }
                return x;
            }
            static int CheckPlaceBot(ArrayList list,int x)
            {
                Boolean a = true;
                int y;
                Random rnd = new Random();
                while (a)
                {
                    if (list[x] != "?")
                    {
                        x = rnd.Next(1, 4);
                        y = rnd.Next(1, 4);
                        if (y == 2) x += 3;
                        if (y == 3) x += 6;
                    }
                    else
                    {
                        a = false;
                    }
                }
                return x;
            }
            static int CheckWin(ArrayList list)
            {
                if ((list[1] == "x" && list[2] == "x" && list[3] == "x") ||
                        (list[4] == "x" && list[5] == "x" && list[6] == "x") ||
                        (list[7] == "x" && list[8] == "x" && list[9] == "x") ||
                        (list[1] == "x" && list[4] == "x" && list[7] == "x") ||
                        (list[2] == "x" && list[5] == "x" && list[8] == "x") ||
                        (list[3] == "x" && list[6] == "x" && list[9] == "x") ||
                        (list[1] == "x" && list[5] == "x" && list[9] == "x") ||
                        (list[3] == "x" && list[5] == "x" && list[7] == "x"))
                {

                    Console.WriteLine("Победили Крестики");
                    return 1;
                }
                if ((list[1] == "O" && list[2] == "O" && list[3] == "O") ||
                   (list[4] == "O" && list[5] == "O" && list[6] == "O") ||
                   (list[7] == "O" && list[8] == "O" && list[9] == "O") ||
                   (list[1] == "O" && list[4] == "O" && list[7] == "O") ||
                   (list[2] == "O" && list[5] == "O" && list[8] == "O") ||
                   (list[3] == "O" && list[6] == "O" && list[9] == "O") ||
                   (list[1] == "O" && list[5] == "O" && list[9] == "O") ||
                   (list[3] == "O" && list[5] == "O" && list[7] == "O"))
                {

                    Console.WriteLine("Победили Нолики");
                    return 1;
                }
                return 0;
            }
        }
    }
}
