// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akk(int m, int n)
{
  if (m == 0)
  { 
    return n + 1;
  }
  else if ((m != 0) && (n == 0))
  {
      return Akk(m - 1, 1);
  }
  else
  {
    return Akk(m - 1, Akk(m, n - 1));
  }
}

int InputM()
{
  System.Console.WriteLine("Введите число M");
  int m = Convert.ToInt32(Console.ReadLine());
  return m;
}

int InputN()
{
  System.Console.WriteLine("Введите число N");
  int n = Convert.ToInt32(Console.ReadLine());
  return n;
}
 int m = InputM();
 int n = InputN();
 System.Console.WriteLine($"m = {m}; n = {n} => A(m,n) = {Akk(m, n)}");