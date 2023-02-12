// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// Фун-я заполнения массива случайными числами
void FillArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
        }
    }
}

// Фун-я вывода массива
void PrintArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i, j]+"\t");
        }
         Console.WriteLine();
    }
}

// Фун-я нахождения минимального значения массива
void minArray(int[,] array)
{
    int min =array[0,0];
    int row =0, column = 0;
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
        
            if(array[i,j]<min) 
            {
            min = array[i,j];
            row = i;
            column = j;
            }
        }
    }
     Console.WriteLine($"Минимальное значения массива находится в строке {row} и столбце {column} и равно {min}");
    int[,] matrix = new int[array.GetLength(0),array.GetLength(1)];
    for(int i =0;i<matrix.GetLength(0);i++)
    {
        for(int j=0; j<matrix.GetLength(1);j++)
        {
            if(i!=row && j!=column)
            {
                matrix[i,j] = array[i,j];
             Console.Write(matrix[i, j]+"\t");
            }
            
        }
        Console.WriteLine();
    }
   
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr = new int[line,column];
FillArray(arr);
PrintArray(arr);
minArray(arr);