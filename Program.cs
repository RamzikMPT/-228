using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace какулька_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, action;
            bool done = false;
            bool firstopen = true;
            while (!done)
            {
                if (firstopen)
                {
                    Console.WriteLine("Возмоные операции: \n 1.сложение \n 2.вычесть  \n 3.умножить \n 4.деление \n 5.степень \n 6.квадратный корень \n 7.1 процент \n 8.факториал \n 9.выход    ");
                    Console.Write("введите номер операции: ");
                    firstopen = false;
                    

                    

                }
                    else
                    {
                    Console.Write("Введите операцию");

                    }
                action = int.Parse(Console.ReadLine());
                
                switch (action)
                {
                    case 1:
                        Console.WriteLine("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("результат сложения ваших чисел: "+ (a + b) );
                        
                        break;
                    case 2:
                        Console.WriteLine("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("результат  ваших вычитания чисел: " + (a - b));
                        
                        break;
                    case 3:
                        Console.WriteLine("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("результат умножения ваших чисел: " + (a * b));
                        

                        break;
                    case 4:
                        Console.WriteLine("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("результат деления  ваших чисел: " + (a / b));
                        

                        break;
                    case 5:
                        Console.WriteLine("Введите 1 число: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 число: ");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine("результат возведения  ваших чисел: " + Math.Pow(a,b));
                        

                        break;
                    case 6:
                        Console.WriteLine("Введите  число: ");
                        a = float.Parse(Console.ReadLine());
                       

                        Console.WriteLine("результат квадратного корня: " + Math.Sqrt(a));
                       

                        break;
                    case 7:
                        Console.WriteLine("Введите  число: ");
                        a = float.Parse(Console.ReadLine());
                        

                        Console.WriteLine("результат одного процента : " + (a * 0.01));
                        

                        break;
                    case 8:
                        Console.WriteLine("Введите  число: ");
                        a = float.Parse(Console.ReadLine());
                        float anw = 1;
                        for (int i = 1; i < 10; i++)
                            anw *= i;
                   
                        Console.WriteLine("результат факториала: " + (anw));
                       
                        break;
                    case 9:
                        done = true;
                        break;
                   
                }


            }


        }
    }
}
