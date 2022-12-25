// Задать N и вывести # до N елочкой 
// N = 3; N = 5; N = 7;

int N = 7;
string a = "#";
string b = "##";
string c = " ";
string d = "  ";
int i = 2;

if 
(N >= i)
{
    System.Console.WriteLine(d + c + a + c + d);
    if 
    (N >= i)
    {
        string e = a + b;
        System.Console.WriteLine(d + e + d);
        i = i + 2;

        if 
        (N >= i)
        {
            System.Console.WriteLine(c + a + b + b + c);
            string f = a + b + b + b;
            i = i + 2;
            if 
            (N >= i)
            {
                System.Console.WriteLine(f);
                i = i + 2;
            }
        }

    }

}