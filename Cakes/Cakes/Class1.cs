using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    internal class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Используйте стрелочки, чтобы перемещаться между пунктами.");
            Console.WriteLine("Enter - сделать выбор.");
            Console.WriteLine("Esc - вернуться назад.");
            int x = 0;                         // Страницы менюшек
            int y = 0;                        // Высота курсора
            int z = 0;                       // Выбранный пункт
            string a, b, c, d, e, f;                       // Строки меню
            string S = " ";                               // Список выбранного
            int s = 0;                                   // Итоговая цена
            string O = "          Практическая №5     ";// Заголовок
            string L = " ";                            // Строка завершения заказа
            a = " ";
            b = "          Заказ тортиков      ";
            c = " ";
            d = "    Открыть меню заказа тортов ";
            e = " ";
            f = " ";
            while (true)                                 // Начало
            {                                           // цикла
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {                                         //
                    y++;                                 //
                }                                       //
                else if (key.Key == ConsoleKey.UpArrow)// С т р е л к и
                {                                     //
                    y--;                             //
                }
                if (key.Key == ConsoleKey.Enter & y == 2 & x == 0)                //
                {                                                                //
                    x++;                                                        //
                }                                                              // П Е Р Е Х О Д Ы
                else if (key.Key == ConsoleKey.Enter & y > 0 & y < 7 & x == 1)//
                {                                                            //       П О
                    x++;                                                    //
                }                                                          // С Т Р А Н И Ц А М
                else if (key.Key == ConsoleKey.Escape & x > 0 & x < 3)    //
                {                                                        //   ( М Е Н Ю )
                    x--;                                                //
                }                                                      //
                else if (key.Key == ConsoleKey.Escape & x == 3)       //
                {                                                    //
                    x = 1;                                          //
                    z = 1;                                         //
                }
                if (key.Key == ConsoleKey.Enter & x == 2 & y == 1)// Форма (переход)
                {                                                //
                    z = 1;                                      //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & x == 2 & y == 2)// Размер (переход)
                {                                                     //
                    z = 2;                                           //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & x == 2 & y == 3)// Вкус (переход)
                {                                                     //
                    z = 3;                                           //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & x == 2 & y == 4)// Кол-во коржей (переход)
                {                                                     //
                    z = 4;                                           //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & x == 2 & y == 5)// Глазурь (переход)
                {                                                     //
                    z = 5;                                           //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & x == 2 & y == 6)// Декор (переход)
                {                                                     //
                    z = 6;                                           //
                    y = 1;
                }

                else if (key.Key == ConsoleKey.Enter & z == 1 & y == 1)                //
                {                                                                     //
                    S = S + " Цилиндр;";                                             //
                    s = s + 125;                                                    //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 1 & y == 2)        // Форма (выбор)
                {                                                             //
                    S = S + " Куб;";                                         //
                    s = s + 100;                                            //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 1 & y == 3)//
                {                                                     //
                    S = S + " Треугольная призма;";                  //
                    s = s + 150;                                    //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & z == 2 & y == 1)                //
                {                                                                     //
                    S = S + " Большой;";                                             //
                    s = s + 400;                                                    //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 2 & y == 2)        // Размер (выбор)
                {                                                             //
                    S = S + " Средний;";                                     //
                    s = s + 290;                                            //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 2 & y == 3)//
                {                                                     //
                    S = S + " Маленький;";                           //
                    s = s + 180;                                    //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & z == 3 & y == 1)                //
                {                                                                     //
                    S = S + " Шоколад;";                                             //
                    s = s + 20;                                                     //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 3 & y == 2)        // Вкус (выбор)
                {                                                             //
                    S = S + " Карамель;";                                    //
                    s = s + 30;                                             //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 3 & y == 3)//
                {                                                     //
                    S = S + " Ягоды;";                               //
                    s = s + 35;                                     //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & z == 4 & y == 1)                //
                {                                                                     //
                    S = S + " Один;";                                                //
                    s = s + 60;                                                     //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 4 & y == 2)        // Кол-во коржей (выбор)
                {                                                             //
                    S = S + " Два;";                                         //
                    s = s + 180;                                            //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 4 & y == 3)//
                {                                                     //
                    S = S + " Три;";                                 //
                    s = s + 240;                                    //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & z == 5 & y == 1)                //
                {                                                                     //
                    S = S + " Шоколад;";                                             //
                    s = s + 5;                                                      //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 5 & y == 2)        // Глазурь (выбор)
                {                                                             //
                    S = S + " Ягоды;";                                       //
                    s = s + 10;                                             //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 5 & y == 3)//
                {                                                     //
                    S = S + " Сливки;";                              //
                    s = s + 15;                                     //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                else if (key.Key == ConsoleKey.Enter & z == 6 & y == 1)                //
                {                                                                     //
                    S = S + " Шоколад;";                                             //
                    s = s + 5;                                                      //
                    x = 1;                                                         //
                    z = 0;                                                        //
                    y = 1;                                                       //
                }                                                               //
                else if (key.Key == ConsoleKey.Enter & z == 6 & y == 2)        // Декор (выбор)
                {                                                             //
                    S = S + " Крем;";                                        //
                    s = s + 10;                                             //
                    x = 1;                                                 //
                    z = 0;                                                //
                    y = 1;                                               //
                }                                                       //
                else if (key.Key == ConsoleKey.Enter & z == 6 & y == 3)//
                {                                                     //
                    S = S + " Ягоды;";                               //
                    s = s + 8;                                      //
                    x = 1;                                         //
                    z = 0;                                        //
                    y = 1;
                }
                if (key.Key == ConsoleKey.Enter & x == 1 & y == 8)                        //
                {                                                                        //
                    x = 0;                                                              //
                    y = 1;                                                             //
                    DateTime t = DateTime.Now;                                        //
                    string t2 = t.ToString();                                        //
                    string p = ("Дата заказа: ");                                   //
                    string p2 = ("Заказ: ");                                       //
                    string p3 = ("Цена: ");                                       //     З А П И С Ь
                    p = p + t2;                                                  //
                    S = p2 + S;                                                 // Р Е З У Л Ь Т А Т О В
                    File.AppendAllText("C:\\NN\\Заказы.txt", p);               //
                    File.AppendAllText("C:\\NN\\Заказы.txt", "\n");           //    З А К А З А
                    File.AppendAllText("C:\\NN\\Заказы.txt", S);             //
                    string s2 = s.ToString();                               // В  Т Е К С Т О В Ы Й
                    p3 = p3 + s2;                                          //
                    File.AppendAllText("C:\\NN\\Заказы.txt", "\n");       //     Ф А Й Л
                    File.AppendAllText("C:\\NN\\Заказы.txt", p3);        //
                    S = " ";                                            //
                    int q = Convert.ToInt32(s2);                       //
                    s = q;                                            //
                    s = 0;                                           //
                    File.AppendAllText("C:\\NN\\Заказы.txt", "\n"); //
                    File.AppendAllText("C:\\NN\\Заказы.txt", "\n");//
                }

                if (x == 0)
                {                                                //
                    O = "          Практическая №5     ";       //
                    a = " ";                                   //
                    b = "          Заказ тортиков      ";     // П Е Р В О Е
                    c = " ";                                 //
                    d = "    Открыть меню заказа тортов ";  // М Е Н Ю
                    e = " ";                               //
                    f = " ";                              //
                    S = " ";                             //
                    s = 0;
                    L = " ";
                }
                else if (x == 1)
                {                                    //
                    O = "Выберите пункт:";          //
                    a = "   Форма";                //
                    b = "   Размер";              // В Т О Р О Е
                    c = "   Вкус";               //
                    d = "   Кол-во коржей";     // М Е Н Ю
                    e = "   Глазурь";          //
                    f = "   Декор";           //
                    L = "   Завершить заказ";//
                }                           //
                else if (x == 2 & z == 1)
                {
                    x++;
                    O = "Форма:";                        //
                    a = "   Цилиндр - 125";             //
                    b = "   Куб - 100";                //
                    c = "   Треугольная призма - 150";// Ф о р м а
                    d = " ";                         //
                    e = " ";                        //
                    f = " ";                       //
                    L = " ";
                }
                else if (x == 2 & z == 2)
                {
                    x++;
                    O = "Размер:";              //
                    a = "   Большой - 400";    //
                    b = "   Средний - 290";   //
                    c = "   Маленький - 180";// Р а з м е р
                    d = " ";                //
                    e = " ";               //
                    f = " ";              //
                    L = " ";
                }
                else if (x == 2 & z == 3)
                {
                    x++;
                    O = "Вкус:";             //
                    a = "   Шоколад - 20";  //
                    b = "   Карамель - 30";//
                    c = "   Ягоды - 35";  // В к у с
                    d = " ";             //
                    e = " ";            //
                    f = " ";           //
                    L = " ";
                }
                else if (x == 2 & z == 4)
                {
                    x++;
                    O = "Кол-во коржей:"; //
                    a = "   Один - 80";  //
                    b = "   Два - 160"; //
                    c = "   Три - 240";// К о л - в о  к о р ж е й
                    d = " ";          //
                    e = " ";         //
                    f = " ";        //
                    L = " ";
                }
                else if (x == 2 & z == 5)
                {
                    x++;
                    O = "Глазурь:";         //
                    a = "   Шоколад - 5";  //
                    b = "   Ягоды - 10";  //
                    c = "   Сливки - 15";// Г л а з у р ь
                    d = " ";            //
                    e = " ";           //
                    f = " ";          //
                    L = " ";
                }
                else if (x == 2 & z == 6)
                {
                    x++;
                    O = "Декор:";         //
                    a = "   Шоколад - 5";//
                    b = "   Крем - 10"; //
                    c = "   Ягоды - 8";// Д е к о р
                    d = " ";          //
                    e = " ";         //
                    f = " ";        //
                    L = " ";
                }

                Console.Clear();
                Console.WriteLine(O); // Заголовок
                Console.WriteLine(a);      // 
                Console.WriteLine(b);     //
                Console.WriteLine(c);    // С т р о ч к и
                Console.WriteLine(d);   // с  п у н к т а м и
                Console.WriteLine(e);  //
                Console.WriteLine(f); //
                Console.WriteLine(" ");
                Console.WriteLine(L); // Завершение
                Console.WriteLine(" ");
                Console.WriteLine("Торт:");
                Console.WriteLine(S);         //
                Console.WriteLine(" ");      // Итог
                Console.WriteLine("Цена:"); //
                Console.WriteLine(s);      //
                Console.SetCursorPosition(0, y);
                Console.WriteLine("->");
            }
        }
    }
}
