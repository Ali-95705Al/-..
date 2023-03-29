// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равнв 3 символа. Первоночальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FinalArray(string[] ArrayOne, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < ArrayOne.Length; i++)
    {
        if (ArrayOne[i].Length <= 3)
        {
            NewArray[count] = ArrayOne[i];
            count++;
        }
    }
}

string[] ArrayOne = new string[4] { "hello", "2", "world", ":-)" };
string[] NewArray = new string[ArrayOne.Length];
FinalArray(ArrayOne, NewArray);
Console.WriteLine("Итоговый массив => ");
PrintArray(NewArray);