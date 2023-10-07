/*Задание:
Класс Матрица
Создать класс "Матрица". Класс должен иметь следующие переменные:

двумерный массив вещественных чисел;
количество строк и столбцов в матрице.
Класс должен иметь следующие методы:

сложение с другой матрицей;
умножение на число;
вывод на печать; 
умножение матриц - по желанию.*/

using System;
namespace Less18
{
    class Matrix
    {
        public int l;
        public int c;
        public double[,] numbers;

        public Matrix(int l, int c)
        {
            this.l = l;
            this.c = c;
            numbers = new Double[l, c];
        }
        public double this [int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
        }
        public void WriteMat()
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Введите элемент матрицы: {i+1} строка; элемент  {j+1}");
                    numbers[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        
        public void PrintMat()
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($" {numbers[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public void MultMat(int h)
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    numbers[i, j] *= h;
                }
            }
        }

        public void SumMatrix(Matrix Ex, Matrix Ax)
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($" {Ex[i, j] + Ax[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Матрица Ex:");
            Console.WriteLine("Размерность матрицы:");
            Console.Write("Строк = ");
            var l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов = ");
            var c = Convert.ToInt32(Console.ReadLine());
            Matrix ex = new Matrix(l, c);
            Console.WriteLine("Ввод элементов");
            ex.WriteMat();
            Console.WriteLine($"Вывод матрицы Ex");
            ex.PrintMat();
            Console.Write($"Умножить матрицу на = ");
            var num = Convert.ToInt32(Console.ReadLine());
            ex.MultMat(num);
            ex.PrintMat();
            
            Console.WriteLine("Матрица Ax:");
            Matrix Ax = new Matrix(l,c);
            Console.WriteLine("Ввод элементов");
            Ax.WriteMat();
            Console.WriteLine($"Вывод матрицы Ax");
            Ax.PrintMat();
            Console.WriteLine("Сложение матриц Ex и Ax");
            Matrix sum = new Matrix(l,c);
            sum.SumMatrix(Ax,ex);

        }
    }
}