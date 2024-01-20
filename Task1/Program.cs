/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
5 12 16 q [STOP]
3 45 342 15 [STOP]
*/

bool IsSumEven(int value) //проверка на чётность суммы
{
    bool res = true;
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    if (sum % 2 == 0)
    {
        res = false;
    }
    return res;
}

bool IsEquQ(string value2) //проверка на наличие символа q
{
    bool res2 = true;
    

    if (value2  == "q")
    {
        res2 = false;
    }
    return res2;
}

int num = 0;
string inputDate;
bool sumEven = true;
bool equQ = true;

while (equQ == true && sumEven == true) //цикл, который бесконечно запрашивает числа с консоли
{
    Console.Write("Введите целое число: ");
    inputDate = Console.ReadLine(); //введёные с консоли числа или символы
    bool check = int.TryParse(inputDate,out num); //проверка, введённые данные - число или символ
    if (check) //если число
    {
        sumEven = IsSumEven(num);
    }
    else //если символ
    {
        equQ = IsEquQ(inputDate);
    }
    
}
Console.Write("Программа остановлена");