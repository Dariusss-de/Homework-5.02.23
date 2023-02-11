// Найти произведение двух матриц

// Фун-я заполнения массива  числами
void FillArray1(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
        }
    }
}

// Фун-я заполнения массива  числами
void FillArray2(int[,] array)
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

// Фун - я умножения 2-х матриц
static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] = matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}
Console.Write("Введите количество строк: ");
int line1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк: ");
int line2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column2 = int.Parse(Console.ReadLine());
int[,] arr1 = new int[line1,column1];
int[,] arr2 = new int[line2,column2];
FillArray1(arr1);
FillArray2(arr2);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
PrintArray(DivMatrix(arr1, arr2));



