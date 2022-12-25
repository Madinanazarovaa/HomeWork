// У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз в год M % , через сколько лет у нас получится купить 
// квартиру за K $ , при том , что цена квартиры также растет на Q % если этот процент больше или равен N ,то вывести в консоль безысходность 

double Function(string name)
{
    System.Console.WriteLine(name);
    double N = Convert.ToDouble(System.Console.ReadLine());
    return N;
}

double N = Function("Введите сумму которую вы кладете в банк");
double K = Function("Введите стоимость квартиры");
    
for (int i = 1; N <= K; i++)
{
    double M = N / 100 * 20;
    N = M + N;
    double Q = K / 100 * 5;
    K = K + Q;

    if 
    (N >= K)
    {
        System.Console.WriteLine($"Через {i} за {K}$");
    }

    if
    (N <= Q)
    {
        System.Console.WriteLine("Безысходность");
        break;
    }
}