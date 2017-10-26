using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_1
{
    public class Arrays
    {
        static public void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
        
        //1. Найти минимальный элемент массива
        static public int MinEl(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }
        //2. Найти максимальный элемент массива
        static public int MaxEl(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;     
        }
        //3. Найти индекс минимального элемента массива
        static public int MinIndex(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                { 
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
        //4. Найти индекс максимального элемента массива
        static public int MaxIndex(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }
        //5. Посчитать сумму элементов массива с нечетными индексами
        static public int OddIndexSum(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();


            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2 != 0)
                {
                    sum = sum + array[i];
                }
            }

            return sum;
        }
        //6. Сделать реверс массива (массив в обратном направлении)
        static public int[] Reverse(int[] array)
        {           
            if (array == null || array.Length == 0 )
                throw new ArgumentException();

            int[] array_reversed = new int[array.Length];
            int index = array.Length - 1;
            {
                for (int j = 0; j < array_reversed.Length; j++)
                {
                    array_reversed[j] = array[index];
                    index -= 1;
                }
            }
            return array_reversed;

        }

        //7. Посчитать количество нечетных элементов массива
        static public int CountOdd(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 != 0)
                {
                    count += 1;
                }
            }
            return count;
        }
        //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2
        static public int[] HalfSwapped(int[] array)
        {
            
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            int[] array_half_reversed = new int[array.Length];
            if (array.Length % 2 == 0)
            {

                int index = array.Length / 2;
                {
                    for (int j = 0; j < array_half_reversed.Length / 2; j++)
                    {
                        array_half_reversed[j] = array[index];
                        index += 1;
                    }
                    index = 0;
                    for (int j = array_half_reversed.Length / 2; j < array_half_reversed.Length; j++)
                    {
                        array_half_reversed[j] = array[index];
                        index += 1;
                    }
                }
                return array_half_reversed;
            }
            else
            {
                int index = (array.Length / 2)+1;
                {
                    for (int j = 0; j < array_half_reversed.Length / 2; j++)
                    {
                        array_half_reversed[j] = array[index];
                        index += 1;
                    }
                    index = 0;
                    for (int j = array_half_reversed.Length / 2; j < array_half_reversed.Length; j++)
                    {
                        array_half_reversed[j] = array[index];
                        index += 1;
                    }
                }
                return array_half_reversed;
            }
        }


        //9. Отсортировать массив (пузырьком (Bubble), выбором (Select), вставками (Insert))
        static public void BubbleSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static public void SelectSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

        }

        static public void InsertSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }

            }
        }

        //10.* Отсортировать массив (Quick, Merge, Shell, Heap)
        static public void QuickSorted(int [] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            Quicksort(array, 0, array.Length - 1);

        }

        static public void MergeSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            Quicksort(array, 0, array.Length - 1);

        }

        static public void ShellSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            Quicksort(array, 0, array.Length - 1);

        }

        static public void HeapSorted(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException();

            Quicksort(array, 0, array.Length - 1);

        }

    }
}
