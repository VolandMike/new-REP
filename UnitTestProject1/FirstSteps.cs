namespace UnitTestProject1
{
    public class FirstSteps
    {
        /**
         *сумма двух чисел
         **/
        public int sum(int x, int y)
        {
            return x + y;
        }
        /**
         * Возвращает произведение чисел x и y.
         * */
        public int mul(int x, int y)
        {
            return x * y;
        }
        /**
         * Возвращает частное от деления чисел x и y.Гарантируется, что y != 0.
            */
        public int div(int x, int y)
        {
            return x / y;
        }
        /**
         * Возвращает остаток от деления чисел x и y.Гарантируется, что y != 0.
            */
        public int mod(int x, int y)
        {
            return x % y;
        }
        /**
         * Возвращает true, если x равен y, иначе false.
         */
        public bool isEqual(int x, int y)
        {
            return x == y;
        }
        /**
         * Возвращает true, если x больше y, иначе false.
         */
        public bool isGreater(int x, int y)
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
        public int sum(int[] array)
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
        public int mul(int[] array)
        {
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
        public int min(int[] array)
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
        public int max(int[] array)
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
        public double average(int[] array)
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
        public bool isSortedDescendant(int[] array)
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


    }
}
/**
 * 



public void cube(int[] array)
Возводит все элементы одномерного массива array в куб.

public boolean find(int[] array, int value)
Возвращает true, если в одномерном массиве array имеется элемент, равный value, иначе false.

public void reverse(int[] array)
Переворачивает одномерный массив array, то есть меняет местами 0-й и последний, 1-й и предпоследний и т.д.элементы.

public boolean isPalindrome(int[] array)
Возвращает true, если одномерный массив является палиндромом, иначе false. Пустой массив считается палиндромом.

 public int sum(int[][] matrix)
Возвращает сумму чисел, заданных двумерным массивом matrix.

public int max(int[][] matrix)
Возвращает максимальное из чисел, заданных двумерным массивом matrix.Для пустого двумерного массива возвращает Integer.MIN_VALUE.

public int diagonalMax(int[][] matrix)
Возвращает максимальное из чисел, находящихся на главной диагонали квадратного двумерного массива matrix.Для пустого двумерного массива возвращает Integer.MIN_VALUE.

public boolean isSortedDescendant(int[][] matrix)
Возвращает true, если все строки двумерного массива matrix строго упорядочены по убыванию, иначе false. Пустой одномерный массив считается упорядоченным.Разные строки массива matrix могут иметь разное количество элементов.При написании метода рекомендуется внутри него вызвать метод из п. 13.  


    }
}
