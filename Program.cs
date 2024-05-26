// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] stringArray = { "Hello", "2", "world", ":-)" };
int CountStringsUpToLengthInArr(string[] strArr, int lengthStrings) //Функция возвращает количество строк в массиве, длина которых меньше, либо равна lengthStrings
{
    int count = 0;
    foreach (string e in strArr)
    {
        if (e.Length <= lengthStrings)
        {
            count += 1;
        }
    }
    return count;
}
string[] СreateArrOfStrUpToLengthOfArr(string[] strArr, int lengthStrings = 3) // Функция создает новый массива из строк, длина которых меньше, либо равна lengthStrings
{
    string[] createArr = new string[CountStringsUpToLengthInArr(strArr, lengthStrings)];
    int countIndexCreateArr = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= lengthStrings)
        {
            createArr[countIndexCreateArr] = strArr[i];
            countIndexCreateArr += 1;
        }
    }
    return createArr;
}

void WriteStrArr(string[] strArr)
{
    foreach (string e in strArr)
    {
        Console.Write($"[{e}] ");
    }
}

string[] arrOfStrUpToThreeChar = СreateArrOfStrUpToLengthOfArr(stringArray);

if (arrOfStrUpToThreeChar.Length > 0)
{
    WriteStrArr(arrOfStrUpToThreeChar);
}
else
{
    Console.WriteLine("В массиве нет строк, необходимой длины");
}