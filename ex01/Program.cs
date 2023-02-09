
void PrintArray(int[] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        Console.Write($" {arg[i]} ");
    }
}

void FillArray(int[] arg, int min, int max)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        arg[i] = new Random().Next(min,max);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int n = ReadInt("Введите количество элементов массива: ");
int minimum = ReadInt("Введите значение минимального элемента: ");
int maximum = ReadInt("Введите значение максимального элемента: ");

int[] array = new int[n];

FillArray(array, minimum, maximum);

PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Ammount of even element: {array.Count(number => number % 2 == 0)}");    //выводит количество четных элементов
Console.WriteLine($"Ammount of odd element: {array.Count(number => number % 2 != 0)}");     //выводит количество нечетных элементов

int[] oddElements = array.Where(x => x % 2 != 0).ToArray();         //вернет все нечетные элементы в новый массив oddElements
PrintArray(oddElements);
Console.WriteLine();

int[] NegateArray = array.Select(x => -x).ToArray();                //вернет все элементы массива на противоположные
PrintArray(NegateArray);