/*Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
*/

int m = InputNumbers("Введите кол-во строк (m): ");//приглашение на ввод данных
int n = InputNumbers("Введите кол-во столбцов (n): ");//приглашение на ввод данных
int range = InputNumbers("Введите диапазон: от 1 до ");//приглашение на ввод данных

int[,] array = new int[m, n];//задать массив из n,m строк-столбцов
CreateArray(array);//вызов функции создания массива
WriteArray(array);//его вывод

Console.WriteLine($"\nОтсортированный массив: ");// \n - это перенос строки, как \t табуляция
OrderArrayLines(array);//вызов ф-ции сортировки
WriteArray(array);//вывод массива

void OrderArrayLines(int[,] array)//функция сортировки
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)//ввод чисел
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
