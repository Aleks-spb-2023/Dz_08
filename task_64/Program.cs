
void printRangeNumber(int N)
{
    if(N == 1)
    {
        return;
    }
    Console.Write($"{N}, ");
    printRangeNumber(N -1);
}


Console.WriteLine("Введите N");
int usernumber =  Convert.ToInt32(Console.ReadLine());
printRangeNumber(usernumber);
 Console.Write(1);
 Console.WriteLine();