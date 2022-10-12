int[,] ArrayOne = new int[2,2]{
    {2,4},
    {3,2}
};

int[,] ArrayTwo = new int[2,2]{
    {3,4},
    {3,3}
};
int[,] NewArray = new int[2,2];
for (int i = 0; i < NewArray.GetLength(0); i++)
{
    for (int j = 0; j < NewArray.GetLength(1); j++)
    {
       int summ = 0;
       for (int k = 0; k <ArrayOne.GetLength(0); k++)
       {
            summ += ArrayOne[i,k] * ArrayTwo[k,j];
       }
       NewArray[i,j] =  summ;
    }
}


for (int i = 0; i < NewArray.GetLength(0); i++)
{
    for (int j = 0; j < NewArray.GetLength(1); j++)
    {
        Console.Write(NewArray[i,j ] + " ");
    }
    Console.WriteLine();
}    