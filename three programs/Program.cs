namespace three_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Практическая работа №2                  ");
            Console.WriteLine("");
            int xx = 0;
            while (xx !=9)
            {
                Console.WriteLine("Выберите один из вариантов: 1 - Угадай число. 2 - Выход.");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1 || x == 2)
                {
                    if (x != 2)
                    {
                        if (x == 1)
                        {
                            Random y = new Random();
                            int y2 = y.Next(1, 100), xx2 = 1;
                            do
                            {
                                int z = Convert.ToInt32(Console.ReadLine());
                                if (z < y2)
                                {
                                    Console.WriteLine("Нужно больше");
                                }
                                else if (z > y2)
                                {
                                    Console.WriteLine("Нужно меньше");
                                }
                                else if (z == y2)
                                {
                                    Console.WriteLine("Вы угадали число");
                                    xx2 = 0;
                                }
                            }
                            while (xx2 != 0);
                        }
                    }
                    else
                    {
                        xx = 9;
                    }
                }
            }
        }
    }
}