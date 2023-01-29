// Task 56.
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.WriteLine($"Укажите размерность матрицы");
int SizeOfMatrix = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[SizeOfMatrix, SizeOfMatrix];
int[] TempMatrix = new int[SizeOfMatrix];
int var = 0;

Console.WriteLine("Сформирован массив");
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        int rand = new Random().Next(0, 10);
        Matrix[i, j] = rand;
        var += rand;
        Console.Write($"{rand} ");
    }
    TempMatrix[i] = var;
    var = 0;
    Console.WriteLine("");
}

int Comparsion = SizeOfMatrix*9;
int Index = 0;
for (int x = 0; x < SizeOfMatrix; x++)
{
    if (Comparsion > TempMatrix[x])
    {
        Comparsion = TempMatrix[x];
        Index = x;
    }
}
Console.WriteLine($"Минимальная сумма {Comparsion}, находится в строке № {Index}");
