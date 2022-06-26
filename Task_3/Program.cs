// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

double[] arrayRandomNumbers = new double[10];
  for (int i = 0; i < arrayRandomNumbers.Length; i++ )
  {
    arrayRandomNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRandomNumbers[i] + " ");
  }

double maxNumber = arrayRandomNumbers[0];
double minNumber = arrayRandomNumbers[0];

  for (int i = 1; i < arrayRandomNumbers.Length; i++)
  {
    if (maxNumber < arrayRandomNumbers[i])
    {
      maxNumber = arrayRandomNumbers[i];
    }
        if (minNumber > arrayRandomNumbers[i])
    {
      minNumber = arrayRandomNumbers[i];
    }
  }
    Console.WriteLine($"всего {arrayRandomNumbers.Length} чисел. Максимальное значение = {maxNumber}, минимальное значение = {minNumber}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {maxNumber - minNumber}");
