{
    Console.Write("Enter the number of rows for the pyramid");
    int numRows = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numRows; i++)
    {
        for (int i =1; j <= i; j++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}