// Составить частотный словарь элементов двумерного массива

// Фун-я заполнения массива  числами
void FillArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = int.Parse(Console.ReadLine());
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

// Фун-я показывающая количество повторяющихся чисел в числе
void NumberisNumbers(int[,] array, int arg1,int arg2)
{
    int quantity =0;
    float num = 0f;
   for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            if(array[i,j] == arg1)
            {
                quantity ++; 
                //Console.WriteLine(quantity);
                num = quantity*100/arg2;
                
            }
            
            
        }
         
    }
    Console.WriteLine($"Число {arg1} встречается в массиве {num} %");
    
}
   
   

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr = new int[line,column];
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
int size = line*column;
Console.WriteLine($"Размер массива {size} элементов");
FillArray(arr);
PrintArray(arr);
NumberisNumbers(arr, number,size);

