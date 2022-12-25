// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Сoordinates(string name)
{
    System.Console.WriteLine(name);
    double Ax = Convert.ToDouble(System.Console.ReadLine());
    return Ax;
}

double Ax = Сoordinates("Введите Ax");
double Ay = Сoordinates("Введите Ay");
double Az = Сoordinates("Введите Az");
double Bx = Сoordinates("Введите Bx");
double By = Сoordinates("Введите By");
double Bz = Сoordinates("Введите Bz");

double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));
System.Console.WriteLine(AB);
