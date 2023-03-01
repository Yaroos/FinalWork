// 2 Массива. Первый из которого нужно вытащить слова короче 3 символом, 
// второй принимает эти значения.
string[] array1 = new string[11] { "hello", "2", "world", ":-)", "1234", 
                                    "1567", "-2", "computer science",
                                    "Russia", "Denmark", "Kazan" };
string[] array2 = new string[array1.Length];

// Метод, извлекающий слова короче 3 символов и записывающий в новый массив.
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

// Метод распечатки массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Вывод в консоль
SecondArrayWithIF(array1, array2);
PrintArray(array2);