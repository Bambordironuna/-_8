//************************************************************/
//* Практическая работа №8                                   */
//* Выполнила: Метлева В.Д., группа 2ИСПД                    */
//* Задание: составить программу работы алгоритма ветвления  */
//************************************************************/



using System;
namespace практическая_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Практическая работа № 8");
            bool error = true;
            double n = 0;
            bool error2 = true;

            do
            {
                Console.Write("Введите n чисел: \n");
                do
                {
                    Console.Write("n = ");
                    try
                    {
                        error2 = false;
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException fex) //не дает ввести букву
                    {
                        error2 = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ошибка: {fex.Message} ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                    }
                    catch (OverflowException oex) //не дает ввеси большое значение
                    {
                        error2 = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ошибка: {oex.Message}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                    }
                    catch (Exception ex)
                    {
                        error2 = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ошибка: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                    }
                } while (error2);


                double sum = 0;
                double i = 1;

                try
                {
                    do
                    {
                        sum += i;
                        i++;
                    } while (i <= n);
                    Console.WriteLine($"Cумма чисел : {sum}");

                    if (sum < 100)
                    {
                        Console.WriteLine("число меньше 100, поэтому возводим в стемень : ");
                        sum = Math.Pow(sum, 3);
                    }
                    else
                    {
                        Console.WriteLine("число больше 100, поэтому вычисляем корень : ");
                        sum = Math.Sqrt(sum);
                    }
                    Console.Write($"Ответ : {Math.Round(sum, 3)}");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ошибка: {ex.Message} ");
                }

                bool error3 = true;
                do
                {
                    Console.WriteLine("\nЕсли хотите повторить, напишите 'да', иначе 'нет'");
                    string letter = Console.ReadLine();
                    switch (letter)
                    {
                        case "да":
                            Console.Clear();
                            error3 = false;
                            error = true;
                            Console.WriteLine("Вы написали да, введите n чисел :");
                            n = 0; i = 1; sum = 0;
                            if (!error)
                                i++;
                            break;
                        case "нет":
                            error3 = false;
                            error = false;
                            Console.WriteLine("Вы написали нет, процесс закончился.");
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы нажали неизвестную букву, повториите попытку.");
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                    }
                } while (error3);
            } while (error);
            Console.ReadKey();
        }
    }
}
