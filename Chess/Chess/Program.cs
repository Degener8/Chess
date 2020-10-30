using System;

namespace Chess
{
    class Program
    {

        static void CheckMove(int fgre, int h1, int v1, int h2, int v2)
        {
            int dh = h1 - h2;
            int dv = v1 - v2;

            switch (fgre)
            {
                case 1:
                    if ((v1 == 2 && dh == 0 && v2 == 4)
                        || (v1 == 7 && dh == 0 && v2 == 5)
                        || (dh == 0 && dv == 1))
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
                case 2:
                    if ((dh == 1 && dv == 2) || (dh == 2 && dv == 1))
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
                case 3:
                    if ((dh == 0 && dv > 0) || (dh > 0 && dv == 0))
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
                case 4:
                    if (dh == dv && dv > 0)
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
                case 5:
                    if (((dh == 0 && dv > 0) || (dh > 0 && dv == 0))
                        || (dh == dv && dv > 0))
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
                case 6:
                    if (((dh == 0 && dv == 1) || (dh == 1 && dv == 0))
                        || (dh == dv && dv == 1))
                        Console.WriteLine("Верно.");
                    else Console.WriteLine("Неверно.");
                    break;
            }
        }

            static void Main(string[] args)
        {
            char[,] board = new char[8,8];
        }
    }
}
