using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class Functions
    {
        //1. Получить строковое название дня недели по номеру дня. 
        static public string DayOfTheWeek(int DayValue)
        {
            if (DayValue < 1 || DayValue > 7)
                throw new ArgumentOutOfRangeException();

            string Day = " ";
            string[] Week = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Day = Week[DayValue - 1];
            return Day;
        }
        //2. Вводим число (0-999), получаем строку с прописью числа.
        public static string NumToSpelled(int value) //40 test (every mas 10) 
        {
            if (value < 0 || value > 999)
                throw new ArgumentOutOfRangeException();

            string res = "";
            string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] des = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixsty", "seventy", "eighty", "ninety" };
            string[] spec = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string hun = "hundred";

            if (value == 0)
                return res = "zero";
            if (value / 100 != 0)
                res = ones[value / 100] + " " + hun;
            if ((value % 100) == 10)
                res = res + " " + des[(value % 100) / 10];
            if ((value % 100) / 10 != 1)
                res = res + " " + des[(value % 100) / 10];
            else
            {
                res = res + " " + spec[(value % 100) % 10];
                return res.Trim();
            }
            res = res.Trim() + " " + ones[value % 10].Trim();
            return res.Trim();
        }
        //3. Вводим строку, которая содержит число, написанное прописью (0-999). Получить само число
        public static int SpelledToNum(string value)
        {

            int res = 0;
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] des = { "", "", "twenty", "thirty", "fourty", "fifty", "sixsty", "seventy", "eighty", "ninety" };
            string[] spec = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string[] words = new string[] { " " };
            string[] result;
            result = value.Split(words, StringSplitOptions.RemoveEmptyEntries);
            if (result.Length == 0)
                throw new ArgumentException();
            if (result.Length == 1)
            {
                for (int i = 0; i < spec.Length; i++)
                {
                    if (spec[i] == result[0])
                        res = i + 10;
                    else if (result[0] == "ten")
                        res = 10;
                    else if (result[0] == "zero")
                        return 0;
                    else
                        for (int j = 0; j < ones.Length; j++)
                        {
                            if (ones[j] == result[0])
                                res = j;
                        }
                }
            }
            if (result.Length == 2)
            {
                if (result[0] == "minus")
                { throw new ArgumentOutOfRangeException(); }
                else
                {
                    if (result[1] == "hundred")
                    {
                        for (int i = 0; i < ones.Length; i++)
                        {
                            if (ones[i] == result[0])
                                res = i * 100;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < des.Length; i++)
                        {
                            if (des[i] == result[0])
                                res = i * 10;
                        }
                        for (int i = 0; i < ones.Length; i++)
                        {
                            if (ones[i] == result[1])
                                res = res + i;
                        }
                    }
                }
            }

            if (result.Length == 3)
            {
                for (int i = 0; i < ones.Length; i++)
                {
                    if (ones[i] == result[0])
                        res = i * 100;
                }
                for (int i = 0; i < spec.Length; i++)
                {
                    if (spec[i] == result[2])
                        res = res + (i + 10);
                    else if (result[2] == "ten")
                        res = 110;
                }
            }

            if (result.Length == 4)
            {
                for (int i = 0; i < ones.Length; i++)
                {
                    if (ones[i] == result[0])
                        res = i * 100;
                }
                for (int i = 0; i < des.Length; i++)
                {
                    if (des[i] == result[2])
                        res = res + i * 10;
                }
                for (int i = 0; i < ones.Length; i++)
                {
                    if (ones[i] == result[3])
                        res = res + i;
                }
            }
            if (result.Length > 4)
                throw new ArgumentOutOfRangeException();

                return res;
            
        }
        //4. Найти расстояние между двумя точками в двуммерном декартовом пространстве.
        public static double Distance(double x1, double y1, double x2, double y2) //тесты: по осям, по координатам
        {
            double dist = 0;
            dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            return dist;
        }
        //5. Для задания 2 расширить диапазон до 999 миллиардов
        //6. Для задания 3 расширить диапазон до 999 миллиардов 

    }
}
