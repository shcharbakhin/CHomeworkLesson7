{
    Console.Write("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Double[,] array = new double[m, n];
    Random rand = new Random();
for (int i=0; i<m; i++)
{
for (int j=0; j<n; j++)
{   array[i,j] = rand.NextDouble();
    Console.Write(array[i,j]);
    Console.Write(" ");
    }
    Console.WriteLine();
}
}
