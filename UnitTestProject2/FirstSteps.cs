using System;
namespace UnitTestProject1
{
    public class FirstSteps
    {
        /**
         *сумма двух чисел
         **/
        public int Sum(int x, int y)
        {
            return x + y;
        }
        /**
         * Возвращает произведение чисел x и y.
         * */
        public int Mul(int x, int y)
        {
            return x * y;
        }
        /**
         * Возвращает частное от деления чисел x и y.Гарантируется, что y != 0.
            */
        public int Div(int x, int y)
        {
            return x / y;
        }
        /**
         * Возвращает остаток от деления чисел x и y.Гарантируется, что y != 0.
            */
        public int Mod(int x, int y)
        {
            return x % y;
        }
        /**
         * Возвращает true, если x равен y, иначе false.
         */
        public bool IsEqual(int x, int y)
        {
            return x == y;
        }
        /**
         * Возвращает true, если x больше y, иначе false.
         */
        public bool IsGreater(int x, int y)
        {
            return x > y;
        }
        /**
         * Прямоугольник с горизонтальными и вертикальными сторонами, 
         * задан двумя точками - левой верхней(xLeft, yTop) и 
         * правой нижней(xRight, yBottom). На плоскости OXY ось X направлена вправо,
         * ось Y - вниз.Дана еще одна точка с координатами(x, y). 
         * Гарантируется, что xLeft<xRight и yTop < yBottom.Метод должен возвращать true,
         * если точка лежит внутри прямоугольника , иначе false.
         * Если точка лежит на границе прямоугольника, то считается, что она лежит внутри 
         ** него.
         */
        public bool IsInsideRect(int xLeft, int yTop, int xRight, int yBottom, int x, int y)
        {
            return xLeft <= x && x <= xRight && yTop <= y && y <= yBottom;

        }
        /**
         * Возвращает сумму чисел, заданных одномерным массивом array.
         * Для пустого одномерного массива возвращает 0.
         */
        public int Sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }
        /**
         * Возвращает произведение чисел, заданных одномерным массивом array.
         * Для пустого одномерного массива возвращает 0.
         */
        public int Mul(int[] array)
        {
            if (array.Length == 0) return 0;
            int mul = 1;
            foreach (int i in array)
            {
                mul *= i;
            }
            return mul;

        }
        /**
         * Возвращает минимальное из чисел, заданных одномерным массивом array.
         * Для пустого одномерного массива возвращает Integer.MAX_VALUE.
         */
        public int Min(int[] array)
        {
            int res = int.MaxValue;
            if (array.Length == 0) return res;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < res)
                    res = array[i];
            }
            return res;
        }
        /**
         * Возвращает максимальное из чисел,
         * заданных одномерным массивом array.
         * Для пустого одномерного массива возвращает Integer.MIN_VALUE.
         */
        public int Max(int[] array)
        {
            int res = int.MinValue;
            if (array.Length == 0) return res;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > res)
                    res = array[i];
            }

            return res;
        }
        /**
         *Возвращает среднее значение для чисел,
         * заданных одномерным массивом array.
         * Для пустого одномерного массива возвращает 0.
 
         */
        public double Average(int[] array)
        {
            int res = 0;
            if (array.Length == 0) return res;
            foreach (int i in array)
            {
                res += i;
            }
            return res / array.Length;
        }

        /**
         * Возвращает true, если одномерный массив array строго упорядочен по убыванию,
         * иначе false. Пустой одномерный массив считается упорядоченным.
         */
        public bool IsSortedDescendant(int[] array)
        {
            if (array.Length == 0) return true;
            int x = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (x < array[i]) { return false; }
                else if (x == array[i]) { return false; }
                if (x > array[i])
                {

                    x = array[i];
                }
            }
            return true;
        }
        /*
         * Возводит все элементы одномерного массива array в куб.
         */
        public void Cube(int[] array) {

            for (int i = 0; i < array.Length; i++) {
                int k = 0;
                k = i * i * i;
                i = k;
            }
        }
        /*
         * Возвращает true, если в одномерном массиве array имеется элемент,
         * равный value, иначе false.
         */
        public bool Find(int[] array, int value) {
            foreach(int i in array)
            {
                if (i == value)
                    return true;
            }
            return false;
        }
        /*
         *Переворачивает одномерный массив array,
         * то есть меняет местами 0-й и последний, 1-й и предпоследний и т.д.элементы.
         */
        public void reverse(int[] array) {
            Array.Reverse(array);
        }
        /*
         * Возвращает true, если одномерный массив является палиндромом,
         * иначе false. Пустой массив считается палиндромом.
         */
        public bool isPalindrome(int[] array) {

            if (array.Length == 0 || array.Length == 1) return true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[array.Length - i - 1] != array[i]) return false;
            }
            return true;
        }
        /**
         * Возвращает сумму чисел, заданных двумерным массивом matrix.
         */
        public int SumMatrix(int[,] matrix) {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int cp = matrix[i,j];
                    sum += cp;
                }
            }
            
            return sum;
        }
        /*
         * Возвращает максимальное из чисел, заданных двумерным массивом matrix.
         * Для пустого двумерного массива возвращает Integer.MIN_VALUE.
         */

        public int MaxElemMatrix(int[,] matrix)
        {
            int elem = int.MinValue;
            if (matrix.GetLength(0) == 0&& matrix.GetLength(1)==0)
            {
                return elem;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i,j] >= elem) elem = matrix[i,j];
                    }
                return elem;
            
           
        }
        /**
         * Возвращает максимальное из чисел, находящихся на главной диагонали 
         * квадратного двумерного массива matrix.Для пустого двумерного массива 
         * возвращает Integer.MIN_VALUE.
         */

        public int diagonalMax(int[,] matrix) {
            int elem = int.MinValue;
            if (matrix.GetLength(0) == 0 && matrix.GetLength(1) == 0)
            {
                return elem;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    if (i == j) {
                        int tmp = matrix[i, j];
                        if (tmp > elem) {
                            elem = tmp;
                        }
                    }
                }

                    return elem;
        }
        /**
         * Возвращает true, если все строки двумерного массива matrix строго 
         * упорядочены по убыванию, иначе false. 
         * Пустой одномерный массив считается упорядоченным.
         * Разные строки массива matrix могут иметь разное количество элементов.
         * При написании метода рекомендуется внутри него вызвать метод из п. 13.
         */

        public bool isSortedDescendant(int[,] matrix) {

            if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return true;
            }

            int prevvalue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                prevvalue = matrix[i,0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] >= prevvalue)
                    {
                        return false;
                    }
                    else
                    {
                        prevvalue = matrix[i,j];
                    }
                }
            }


            return true;
        }


    }
}
