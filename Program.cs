Console.Clear();
restart:
Console.WriteLine("1-5 Практические задачи");
Console.WriteLine("6 Дополнительная задача");
Console.WriteLine("7 Рекурсия на перестаноку");
Console.WriteLine("8 Транспонирование");
Console.WriteLine("9 Миша и негатив");
Console.Write("Что бы запустить какую то конкретную задачу введите номер этой задачи то 1 до 9: ");
int Task = int.Parse(Console.ReadLine());
switch (Task)
{
    case 1:/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
        int[,] InputMatrix(int[,] matrix)
        {
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(1, 11); // [1, 10]
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            return matrix;
        }
        void RowsInDescendingOrder(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int n = 0; n < matrix.GetLength(1) - 1; n++)
                    {
                        if (matrix[i, n] < matrix[i, n + 1])
                        {
                            int a = matrix[i, n + 1];
                            matrix[i, n + 1] = matrix[i, n];
                            matrix[i, n] = a;
                        }
                    }
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        int[,] matrix = new int[3, 4];
        InputMatrix(matrix);
        System.Console.WriteLine();
        RowsInDescendingOrder(matrix);
        break;
    case 2: /*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
        int SumRowsMatrix(int[,] matrix, int i)
        {
            int a = matrix[i, 0]; ;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                a += matrix[i, j];
            }
            System.Console.WriteLine(a);
            return a;
        }
        matrix = new int[5, 4];
        InputMatrix(matrix);
        System.Console.WriteLine();
        int min = 0;
        int temp1 = SumRowsMatrix(matrix, 0);
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int temp2 = SumRowsMatrix(matrix, i);
            if (temp1 > temp2)
            {
                temp1 = temp2;
                min = i;
            }
        }
        System.Console.WriteLine(min);
        break;
    case 3: /*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
        void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] matrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < firstMatrix.GetLength(1); k++)
                    {
                        sum += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                    matrix[i, j] = sum;
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        InputMatrix(matrix1);
        System.Console.WriteLine();
        InputMatrix(matrix2);
        System.Console.WriteLine();
        MultiplicationMatrix(matrix1, matrix2);
        break;
    case 4: /*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
        void Input3DArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {//лень вводить руками по этому для скорости используем рандом
                        array[i, j, k] = new Random().Next(10, 99); //очень мал шанс что цифры повторятся
                        Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
                    }
                }
                Console.WriteLine();
            }
        }
        int[,,] array3d = new int[2, 2, 2];
        Input3DArray(array3d);
        break;
    case 5: /*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/
        int[,] sqareMatrix = new int[4, 4];
        int temp = 1;
        int k = 0;
        int l = 0;
        while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
        {
            sqareMatrix[k, l] = temp;
            temp++;
            if (k <= l + 1 && k + l < sqareMatrix.GetLength(1) - 1)
                l++;
            else if (k < l && k + l >= sqareMatrix.GetLength(0) - 1)
                k++;
            else if (k >= l && k + l > sqareMatrix.GetLength(1) - 1)
                l--;
            else
                k--;
        }
        for (int i = 0; i < sqareMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sqareMatrix.GetLength(1); j++)
            {
                Console.Write($" {sqareMatrix[i, j]}\t");
            }
            Console.WriteLine();
        }
        break;
    case 6: /*Треугольник Паскаля
            Вывести первые N строк треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.*/
        float Factorial(int n)
        {
            float x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
        Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= (n - i); j++) // отступы
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" "); // пробелы между элементами треугольника
                Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        break;
    case 7: /*Рекурсия(https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=9&id_topic=123&id_problem=765)
            Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.*/
        void Swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
        void Permutation(char[] a, int i, int n)
        {
            if (i == n)
                Console.WriteLine(a);
            else
            {
                for (int j = i; j <= n; j++)
                {
                    Swap(ref a[i], ref a[j]);
                    Permutation(a, i + 1, n);
                    Swap(ref a[i], ref a[j]);
                }
            }
        }
        Console.Write("Введите символы для перестановки: ");
        string str = Console.ReadLine();
        char[] charStr = str.ToCharArray();
        Permutation(charStr, 0, charStr.Length - 1);
        break;
    case 8: /*Транспонирование(https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=745)
            Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.*/
        void TranspositionMatrix(int[,] matrix)
        {
            Console.WriteLine("Транспонированная матрица: ");
            int[,] temp = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = matrix[j, i];
                    Console.Write($"{temp[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        void TranspositionMatrixHorizontal(int[,] matrix)
        {
            Console.WriteLine("Транспонированная матрица относительно горизонтали: ");
            int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
                    Console.Write($"{temp[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        Console.Write("Введите размер матрицы: ");
        int[] elem = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
        int[,] matrix3 = new int[elem[0], elem[1]];
        InputMatrix(matrix3);
        System.Console.WriteLine();
        TranspositionMatrix(matrix3);
        System.Console.WriteLine();
        TranspositionMatrixHorizontal(matrix3);
        break;
    case 9: /*Миша и негатив(https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=121&id_problem=749)*/
        char[,] photo =    {{'W','B','B','W'},
                            {'B','B','B','B'},
                            {'W','B','B','W'}};
        char[,] negative = {{'B','W','W','W'},
                            {'W','W','W','B'},
                            {'B','W','W','B'}};
        int count = 0;
        for (int i = 0; i < photo.GetLength(0); i++)
        {
            for (int j = 0; j < photo.GetLength(1); j++)
            {
                if (photo[i,j] == negative[i,j])
                count ++;
            }
        }
        Console.WriteLine($"Количество неправильных пикселей: {count}");
        break;
    default:
        goto restart;
}