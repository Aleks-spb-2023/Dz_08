int GetSummRange(int M, int N)
{
    if(M == N + 1)
    {
        return 0;
    }
    return M + GetSummRange(M + 1,N);
}
Console.WriteLine("Введите начальное число ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число число ");
int end = Convert.ToInt32(Console.ReadLine());Console.WriteLine("Введите начальное число ");
Console.WriteLine($"Сумма элементов от {start} до {end} = {GetSummRange(start,end)}");