using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_1
{
    public class Conditions
    {
        //1. Если а – четное посчитать а*б, иначе а+б
        public static int EvenAMultBOddAPlusB(int a, int b) //3 теста
        {
            int res = 0;
            if (a % 2 == 0)
                res = a * b;
            else
                res = a + b;
            return res;           
        }

        /*2. Определить какой четверти принадлежит точка с координатами (х,у)
                             II|I
                            -------->
                            III|IV*/
        public static int Quarter(int x, int y) // 
        {
            if (x == 0 || y == 0)
                throw new ArgumentOutOfRangeException();

            int quarter = 5;
            if (x<0 && y<0)
                quarter = 3;
            else if (x<0 && y>0)
                quarter = 2;
            else if (x > 0 && y > 0)
                quarter = 1;
            else if (x > 0 && y < 0)
                quarter = 4;
            return quarter;
        }

            //3. Найти сумму только положительных из трех чисел
        public static int SumPositiveNum(int a, int b, int c) //6
        {
            int res = 0;
            if (a > 0)
                res = res + a;
            if (b > 0)
                res = res + b;
            if (c > 0)
                res = res + c;
            return res;
         }

            //4. Посчитать выражение макс(а*б*с, а+б+с)+3
        public static int MaxOfaPbPc_aMbMcPlus3(int a, int b, int c) //3
        {
            int mult = a * b * c;
            int sum = a + b + c;
            int res = 0;
            if (mult >= sum)
                res = mult + 3;
            else
                res = sum + 3;
            return res;
        }

        /*5. Написать программу определения оценки студента по его рейтингу, на основе следующих правил:
                F = 0-19                       
                E = 20-39                
                D = 40-59                
                C = 60-74                
                B = 75-89               
                A = 90-100
                */
        public static char Rating(int rating) //20
        {
            if (rating < 0 || rating > 100)
                throw new ArgumentOutOfRangeException();
            char res = (char)0;

            if (rating >= 0 && rating <= 19)
                res = 'F';
            else if (rating >= 20 && rating <= 39)
                res = 'E';
            else if (rating >= 40 && rating <= 59)
                res = 'D';
            else if (rating >= 60 && rating <= 74)
                res = 'C';
            else if (rating >= 75 && rating <= 89)
                res = 'B';
            else if (rating >= 90 && rating <= 100)
                res = 'A';

            return res; 
        }

    }
}
