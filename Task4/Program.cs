// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

// Фун-я заполнения массива случайными числами
/*
void FillArray(int[,,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int z=0;z<array.GetLength(2);z++)
            array[i,j,z] = new Random().Next(-99,99);
        }
    }
}

// Фун-я вывода массива
void PrintArray(int[,,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int z=0;z<array.GetLength(2);z++)
            {
                Console.WriteLine($"Элемент массива с индексами {i} {j} {z} равен {array[i,j,z]}");
            }
        
        }
    }
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите количество z: ");
int z = int.Parse(Console.ReadLine());
int[,,] arr = new int[line,column,z];
FillArray(arr);
PrintArray(arr);
*/

// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента(Вариант 2 более красивый вывод)
// Фун-я заполнения массива случайными числами
void FillArray(int[,,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int z=0;z<array.GetLength(2);z++)
            array[i,j,z] = new Random().Next(-99,99);
        }
    }
}

// Фун-я вывода массива
void PrintArray(int[,,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        Console.WriteLine("Page № "+(i+1));
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int z=0;z<array.GetLength(2);z++)
            {
                Console.Write(array[i,j,z]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("==========================");
    }
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите количество z: ");
int z = int.Parse(Console.ReadLine());
int[,,] arr = new int[line,column,z];
FillArray(arr);
PrintArray(arr);
