using System;

namespace Lesson6
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //Используя цикл foreach, выведите на экран все элементы массива целых чисел, которые больше 20 и меньше 50.
      int[] numbers = {10, 15, 20, 25, 30, 35, 40, 45, 50, 55};
      foreach (int result in numbers)
      {
        if (result > 20 && result < 50)
        {
          Console.WriteLine(result);
        }
      }
    }
  }
}