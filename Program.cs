// Задача 34.
// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void ArrayRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine()); 

int[] numbers = new int[sizeArray];
ArrayRandom(numbers);
ShowArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Even numbers in an array -> {count}");
*/
// Задача 36.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int [] CreateNewArray( int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumOdd(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input minimal possible value on array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximal possible value on array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray(sizeArray, minValue, maxValue);
ShowArray(newArray);

int resSum = FindSumOdd(newArray);
Console.Write($"Sum of odd elements is {resSum}");

*/
// Задача 38.
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. 
// [3.0 7.1 22.5 2.7 78.8] -> 76.1


void ArrayRandomDouble(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine()); 


double[] numbers = new double[sizeArray];
ArrayRandomDouble(numbers);

ShowArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"The difference between the maximum and minimum values is {Math.Round(max - min, 2)}");


