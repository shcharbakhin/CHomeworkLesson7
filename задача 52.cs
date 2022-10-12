{
    Random rand = new Random();
    int m = rand.Next(2, 10);
    Console.WriteLine($"количество строк: {m}");
    int n = rand.Next(2, 10);
    Console.WriteLine($"количество столбцов: {n}");
    int[,] array = new int[m, n];
    int i;
    int j;
    double srednee = 0;
    double summa =0; 
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
          Console.WriteLine();
    }
   Console.WriteLine("Сумма всех элементов и их среднее арифметическое каждого столбца:");
 for (j = 0; j < n; j++)
    {
        summa=0;
        for (i = 0; i < m; i++)
        {
            summa = summa + array[i, j];

        }
        Console.WriteLine(summa);
        srednee = summa / m;
        Console.WriteLine(srednee);
        
    }   
}