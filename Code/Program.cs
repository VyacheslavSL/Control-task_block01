// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами


string[] arr1 = new string[] {"345", "23", "hello", "world", "res", "abc"};
string[] arr2 = new string[arr1.Length];

void SecondArray(string[] array1, string[] array2)
{
    for (int i = 0, j = 0; i < array1.Length; i++, j++)
    {
        if(array1[i].Length <= 3)
        {
            array2[j] = array1[i];
        }
        else
            array2[j] = "*";
    }
    
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ShowArray(arr1);
SecondArray(arr1, arr2);
ShowArray(arr2);