/*
Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
Пример вы найдете в конце презентации к семинару.
[1 3 5 6 7 8] => [8 7 6 5 3 1]
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

void ResArray(int[] inputArray)
{
    Console.WriteLine("Переворачиваю");
    int[] resArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length;i++)
    {
        resArray[i] = inputArray[inputArray.Length-1 -i];
        Console.Write($"{resArray[i]} ");
    }  
} 
Console.Write("Введите количество элементов массива: ");
//int sizeOfArray = Convert.ToInt32(Console.ReadLine()); //или так
int sizeOfArray = Int32.Parse(Console.ReadLine()); //или так
int [] arrayTask3 = NewArray(sizeOfArray);
PrintArray(arrayTask3);
ResArray(arrayTask3);