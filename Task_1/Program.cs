// Задайте массив заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Получившийся массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} числа из массива являются четными");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int x = 0; x < numbers.Length; x++)
    {
        numbers[x] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int x = 0; x < numbers.Length; x++)
    {
        Console.Write(numbers[x] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
