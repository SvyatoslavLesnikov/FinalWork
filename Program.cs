// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] FilterStringsByLength(string[] inputArray)
{
    string[] resultArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}

Console.WriteLine("Введите строку массива:");
string input = Console.ReadLine();
string[] inputArray = input.Split(' ');
string[] resultArray = FilterStringsByLength(inputArray);
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
Console.Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write("\"" + resultArray[i] + "\"");
    if (i < resultArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");