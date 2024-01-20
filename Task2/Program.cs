/*
Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[344 452 341 125] => 2
*/

int[] NewArray(int countOfElem)
{
    int[] newArray = new int[countOfElem];
    Random rnd1 = new Random();
    for (int i = 0; i < countOfElem; i++)
    {
        newArray[i] = rnd1.Next(99, 1000); // только трёхзначные числа от 100 до 999
    }
    return newArray;
}

void PrintArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
    Console.WriteLine();
}

int CountOfEvenElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    /*
    foreach (int elem in arr)
    {
        if (arr[i] % 2 == 0)
        count++
    }
    */
    return count;
}

Console.Write("Введите количество элементов массива: ");
//int sizeOfArray = Convert.ToInt32(Console.ReadLine()); //или так
int sizeOfArray = Int32.Parse(Console.ReadLine()); //или так
int [] arrayTask2 = NewArray(sizeOfArray);
PrintArray(arrayTask2);
Console.WriteLine($"Количество чётных элементов: {CountOfEvenElem(arrayTask2)}");