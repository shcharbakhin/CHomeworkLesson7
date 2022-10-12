{
    Random rand = new Random();
    int m = rand.Next(2, 10);
    int n = rand.Next(2, 10);
    int[,] array = new int[m, n];
    int i;
    int j;
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array[i, j] = rand.Next();
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    i = 0;
    j = 0;
    Console.Write("Введите строку, на которой находится элемент массива:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец, на котором находится элемент массива:");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a < m && b < n)
    {
        Console.WriteLine("значение элемента с указанной позицией в массиве:");
        Console.WriteLine(array[a-1, b-1]);
    }
    else
    {
        Console.WriteLine("такого элемента в массиве нет.");
    }
}
