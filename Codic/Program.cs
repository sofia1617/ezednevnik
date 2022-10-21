using System;

namespace Codick
{
    internal class Program
    {
        static DateTime vremya = DateTime.Now;
        /// <summary>
        /// Влево вправо
        /// </summary>
        static int TudaSuda = 0;
        static int Dela = 2;
        static void Main(string[] args)
        {
            Zametka a = new Zametka()
            {
                Den = 21,
                Imya = "сходить покушать",
                Opisaniye = "Поесть еду Матушки или купить что-нибудь"
            };
            Zametka.zametks.Add(a);
            Zametka b = new Zametka()
            {
                Den = 21,
                Imya = "купить пива",
                Opisaniye = "В магазине акция!!!!!!!!!"
            };
            Zametka.zametks.Add(b);
            Zametka c = new Zametka()
            {
                Den = 21,
                Imya = "скататься в Питер",
                Opisaniye = "В Питере пить... "
            };
            Zametka.zametks.Add(c);
            Zametka d = new Zametka()
            {
                Den = 20,
                Imya = "Сделать матешу",
                Opisaniye = "а зачем в это описание лезть, Это что геометрия тебе????"
            };
            Zametka.zametks.Add(d);
            Zametka e = new Zametka()
            {
                Den = 20,
                Imya = "прийти на пары",
                Opisaniye = "забыть голову"
            };
            Zametka.zametks.Add(e);
            Zametka f = new Zametka()
            {
                Den = 20,
                Imya = "сходить в мираторг",
                Opisaniye = "купить софие алексеевне детского шампанского"
            };
            Zametka.zametks.Add(f);
            Zametka g = new Zametka()
            {
                Den = 22,
                Imya = "пойти гулять",
                Opisaniye = "привет Ариша, Ариша и Полина)"
            };
            Zametka.zametks.Add(g);
            Zametka h = new Zametka()
            {
                Den = 22,
                Imya = "сделать заказ на вайлдберриз",
                Opisaniye = "денек нет(( но вы держитесь брат!)"
            };
            Zametka.zametks.Add(h);
            Zametka i = new Zametka()
            {
                Den = 22,
                Imya = "прийти на БЖД",
                Opisaniye = "сломать ногти при разборе автомата"
            };
            Zametka.zametks.Add(i);

            while (true)
            {
                Alfavite();
                Clavishka();
                Strelochechka();
            }
        }


        private static void Alfavite()
        {
            int mestniiyNomerok = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Дела на:{vremya.AddDays(TudaSuda).Day}.{vremya.AddDays(TudaSuda).Month}.{vremya.AddDays(TudaSuda).Year}");
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Den == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    Console.SetCursorPosition(4, mestniiyNomerok + 1);
                    elementik.Nomer = mestniiyNomerok;
                    Console.Write($"{elementik.Nomer}.{elementik.Imya}\n");
                }
            }

        }
        private static void Clavishka()
        //метод отрисовки задач
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    TudaSuda--;
                    break;
                case ConsoleKey.RightArrow:
                    TudaSuda++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Dela < 3)
                    {
                        Dela = 2;
                    }
                    else
                    {
                        Dela--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Dela > 3)
                    {
                        Dela = 4;
                    }
                    else
                    {
                        Dela++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Пока покаа!");
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int mestniiyNomerok = 0;
            Console.Clear();
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Den == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    elementik.Nomer = mestniiyNomerok;
                    if (mestniiyNomerok == Dela - 1)
                    {
                        Console.Write($"  {elementik.Imya}\n");
                        Console.Write(" " + elementik.Opisaniye);
                    }
                }
            }
        }

        private static void Strelochechka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Dela);
            Console.Write("-->");
        }
    }
}
