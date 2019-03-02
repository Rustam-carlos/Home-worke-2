using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_worke_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.	Написать программу, которая считывает символы с клавиатуры," +
                " пока не будет введена точка. Программа должна сосчитать количество введенных " +
                " пользователем пробелов");
            Console.WriteLine("Введите ваш текст: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Колличество пробелов в вашем тексте = " + spaceCount);


            Console.WriteLine("2.	Ввести с клавиатуры номер трамвайного" +
                " билета (6-значное число) и про-верить является ли данный " +
                "билет счастливым (если на билете напечатано шестизначное " +
                "число, и сумма первых трёх цифр равна сумме последних трёх, " +
                "то этот билет считается счастливым).");


            int[] mas = new int[6];
            Console.Write("Введите номер трамвайного билета (6-значное число) через клавишу enter: \n");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("введите  " + (i + 1) + "  цифру ");
                string s = Console.ReadLine();
                mas[i] = Int32.Parse(s);
            }
            for (int i = 0; i < 6; i++)
                Console.Write("{0} ", mas[i]);
            Console.WriteLine("\n");

            int leftNumber = 0;
            int rightNumber = 0;

            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    leftNumber += mas[i];
                }

                else rightNumber += mas[i];
            }

            if (leftNumber == rightNumber)
            {
                Console.WriteLine("У вас счастливый билет: " + leftNumber + " и  " + rightNumber);
            }

            else Console.WriteLine("Ной не ныл и ты не ной " + leftNumber + " и  " + rightNumber);


            Console.WriteLine("3.	Числовые значения символов нижнего регистра в коде ASCII отличаются " +
                "от значений символов верхнего регистра на величину 32. Используя эту информацию, " +
                "написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра " +
                "в символы верхнего регистра и наоборот.");
            char[] array;
            string input, output;

            Console.Write("Жмакните свою строку: ");
            input = Console.ReadLine();

            array = input.ToCharArray(0, input.Length);
            for (int i = 0; i < array.Length; i++)
            {
                int symbolCode = (int)array[i];
                if (symbolCode >= 65 && symbolCode <= 90)
                    symbolCode += 32;
                else if (symbolCode >= 97 && symbolCode <= 122)
                    symbolCode -= 32;

                array[i] = (char)symbolCode;
            }

            output = String.Join("", array);
            Console.Write("И...и..и.." + output + "  Вуаля!!! \n");

            Console.WriteLine("4.	Даны целые положительные числа A и B (A < B). " +
                "Вывести все целые числа от A до B включительно; каждое число должно " +
                "выводиться на новой строке; при этом каждое число должно выводиться " +
                "количество раз, равное его значению. ");

            bool isInt;
            int a, b;
            Console.WriteLine("Давай числа А и В. Главное чтобы A < B. Не напутай");
            do
            {
                Console.Write("A: ");
                isInt = int.TryParse(Console.ReadLine(), out a);
                if (!isInt) Console.WriteLine("Да уж! Школу небось прогуливал");

            } while (!isInt);

            do
            {
                Console.Write("B: ");
                isInt = int.TryParse(Console.ReadLine(), out b);
                if (!isInt || b < a) Console.WriteLine("Да уж! Школу небось прогуливал");

            } while (!isInt || b < a);


            for (int i = a; a <= b; a++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("5.	Дано целое число N (> 0), найти число, полученное при " +
                "прочтении числа N справа налево. Например, если было введено число 345, то " +
                "программа должна вывести число 543.");


            Console.WriteLine("Введите ваше число: ");
            var n = int.Parse(Console.ReadLine());
            var xArr = n.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            int s = xArr.Length;
            int[] mas = new int[s];            
            for (int i=s, j = 0; i > 0 && j <=s; i--, j++)
            {
                mas[j] = xArr[i - 1];
            }
            string value = String.Concat<int>(mas);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
