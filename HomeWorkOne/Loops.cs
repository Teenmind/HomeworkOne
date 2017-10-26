using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class Loops
    {
        //1. Найти сумму четных чисел и их количество в диапазоне от 1 до 99
        static public int SumAndNumOfEvenFrom1to99_Sum() //2
        {
            int sum = 0;
            for (int i = 1; i<100; i++)
            {
                if(i%2 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        static public int SumAndNumOfEvenFrom1to99_Num()
        {
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        //2. Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)
        static public bool Simple(int number) //3
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();

            int count = 0;
            bool res;

            for (int i = 1; i<=number; i++)
            { 
                if(number%i == 0)
                {
                    count = count + 1;
                }
            }
            if (count == 2)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
        //3. Найти корень натурального числа с точностью до целого (рассмотреть вариант последовательного подбора и метод бинарного поиска)
        static public int SqrtToInt(int number) //5
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();

            int root = 0;
            int res = 0;
            while((root*root)<=number)
            {
                root++;
            }
            res = root - 1;

            return res;
        }
        //4. Вычислить факториал числа n
        static public int Factorial(int n) //3
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException();
            int factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        //5. Посчитать сумму цифр заданного числа
        static public int SumOfNaturalDigits(int number) //5-6
        {
            if(number < 0)
                throw new ArgumentException();
            int sum = 0;
            while (number != 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            return sum;
        }
        //6. Вывести число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321
        static public int Mirrored(int number) //5-6
        {
            int mirrored = 0;
            int count = 0;
            int pow_n = number;
            while (pow_n != 0)
            {
                count++;
                pow_n = pow_n / 10;
            }
            while (number != 0)
            {
                count--;
                mirrored = (int)(mirrored + ((number % 10) * Math.Pow(10, count)));
                number = number / 10;
            }
            return mirrored;         
        }
    }
}
