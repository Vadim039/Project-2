using System.ComponentModel.Design;
using System.Numerics;

namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 Практическая работа №4");
            Console.WriteLine("Используйте клавиши - стрелки и Enter, чтобы выбрать заметку");
            int x = 0;
            int y = 0;
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                else if (Key.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                Console.Clear();
                if (Key.Key == ConsoleKey.Enter & x == 0 & y == 1){
                    L1();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 0 & y == 2){
                    L2();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 1 & y == 1){
                    L3();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 1 & y == 2){
                    L4();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 1 & y == 3){
                    L5();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 1 & y == 4){
                    L6();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 2 & y == 1){
                    L7();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 2 & y == 2){
                    L8();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 2 & y == 3){
                    L9();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 3 & y == 1){
                    L10();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 3 & y == 2){
                    L11();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 3 & y == 3){
                    L12();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 4 & y == 1){
                    L13();
                }
                else if (Key.Key == ConsoleKey.Enter & x == 4 & y == 2){
                    L14();
                }
                else if (x == 0)
                {
                    M1();
                }
                else if (x == 1)
                {
                    M2();
                }
                else if (x == 2)
                {
                    M3();
                }
                else if (x == 3)
                {
                    M4();
                }
                else if (x == 4)
                {
                    M5();
                }
                if (Key.Key != ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("-> ");
                }
            }
            static void M1()
            {
                Console.WriteLine("   11.10.2022");
                Console.WriteLine("   Придти на пары");
                Console.WriteLine("   Распределить время");
            }
            static void M2()
            {
                Console.WriteLine("   12.10.2022");
                Console.WriteLine("   Выполнить задачи");
                Console.WriteLine("   Придти на пары");
                Console.WriteLine("   Распределить время");
                Console.WriteLine("   Выполнить задачи 2");
            }
            static void M3()
            {
                Console.WriteLine("   13.10.2022");
                Console.WriteLine("   Придти на пары");
                Console.WriteLine("   Распределить время");
                Console.WriteLine("   Выполнить задачи");
            }
            static void M4()
            {
                Console.WriteLine("   14.10.2022");
                Console.WriteLine("   Придти на пары");
                Console.WriteLine("   Распределить время");
                Console.WriteLine("   Выполнить задачи");
            }
            static void M5()
            {
                Console.WriteLine("   15.10.2022");
                Console.WriteLine("   Придти на пары");
                Console.WriteLine("   Выполнить оставшиеся задачи");
            }
            static void L1()
            {
                Console.WriteLine("Придти на пары");
                Console.WriteLine("");
                Console.WriteLine("с 1 по 4 пары.");
                Console.WriteLine("11.10.2022");
            }
            static void L2()
            {
                Console.WriteLine("Распределить время");
                Console.WriteLine("");
                Console.WriteLine("Распределить оставшееся время для эффективного решения задач и одыха.");
                Console.WriteLine("11.10.2022");
            }
            static void L3()
            {
                Console.WriteLine("Выполнить задачи");
                Console.WriteLine("");
                Console.WriteLine("Выполнить задания к следующим дням.");
                Console.WriteLine("12.10.2022");
            }
            static void L4()
            {
                Console.WriteLine("Придти на пары");
                Console.WriteLine("");
                Console.WriteLine("с 3 по 5 пары.");
                Console.WriteLine("12.10.2022");
            }
            static void L5()
            {
                Console.WriteLine("Распределить время");
                Console.WriteLine("");
                Console.WriteLine("Распределить оставшееся время для эффективного решения задач и одыха.");
                Console.WriteLine("12.10.2022");
            }
            static void L6()
            {
                Console.WriteLine("Выполнить задачи 2");
                Console.WriteLine("");
                Console.WriteLine("Выполнить задания к следующим дням.");
                Console.WriteLine("12.10.2022");
            }
            static void L7()
            {
                Console.WriteLine("Придти на пары");
                Console.WriteLine("");
                Console.WriteLine("с 1 по 4 пары.");
                Console.WriteLine("13.10.2022");
            }
            static void L8()
            {
                Console.WriteLine("Распределить время");
                Console.WriteLine("");
                Console.WriteLine("Распределить оставшееся время для эффективного решения задач и одыха.");
                Console.WriteLine("13.10.2022");
            }
            static void L9()
            {
                Console.WriteLine("Выполнить задачи");
                Console.WriteLine("");
                Console.WriteLine("Выполнить задания к следующим дням.");
                Console.WriteLine("13.10.2022");
            }
            static void L10()
            {
                Console.WriteLine("Придти на пары");
                Console.WriteLine("");
                Console.WriteLine("с 1 по 4 пары.");
                Console.WriteLine("14.10.2022");
            }
            static void L11()
            {
                Console.WriteLine("Распределить время");
                Console.WriteLine("");
                Console.WriteLine("Распределить оставшееся время для эффективного решения задач и одыха.");
                Console.WriteLine("14.10.2022");
            }
            static void L12()
            {
                Console.WriteLine("Выполнить задачи");
                Console.WriteLine("");
                Console.WriteLine("Выполнить задания к следующим дням.");
                Console.WriteLine("14.10.2022");
            }
            static void L13()
            {
                Console.WriteLine("Придти на пары");
                Console.WriteLine("");
                Console.WriteLine("с 1 по 3 пары.");
                Console.WriteLine("15.10.2022");
            }
            static void L14()
            {
                Console.WriteLine("Выполнить оставшиеся задачи");
                Console.WriteLine("");
                Console.WriteLine("Выполнить задания к следующим дням.");
                Console.WriteLine("15.10.2022");
            }
        }
    }
}