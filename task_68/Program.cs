
int GetAkermanNumber(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n== 0))
      return GetAkermanNumber(m - 1, 1);
    else
      return GetAkermanNumber(m - 1, GetAkermanNumber(m, n - 1));
}
Console.WriteLine(GetAkermanNumber(3,2));