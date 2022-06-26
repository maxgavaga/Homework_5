// Загадайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int size, int min, int max)
  {
  int[] randomNumbers = new int[size];
  int sum = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + randomNumbers[i];
      }
    }
  return sum;
  }

int randomNumbers =  RandomNumbers(size, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях = {randomNumbers}");