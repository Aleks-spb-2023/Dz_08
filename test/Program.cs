Console.WriteLine("Введите количество столбцов массива ");
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива ");
int row = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[row,Column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < Column; j++)
    {
        Array[i,j] = new Random().Next(1,49);
    }
}


for (int p = 0; p < row; p++)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1) - 1; j++)
        {
            if (Array[i, j] < Array[i, j + 1])
            {
                (Array[i, j], Array[i, j + 1]) = (Array[i, j + 1], Array[i, j]);


            }


        }
    }


}
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {

        Console.Write(Array[i, j] + "\t");
    }
    Console.WriteLine();
}