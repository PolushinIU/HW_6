// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double Promt(string message)
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}

double [] FindCross(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        double [] n = new double [1];
        if (b1 == b2)
        {
            n[0] = 1;
            return n;
        }
        else
        {
            return n;
        }
    }
    double [] result = new double[2];
    result[0] = (b1 - b2) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}
void Result(double [] res, double k1, double b1, double k2, double b2)
{
    if (res.Length == 1)
    {
        if (res[0] == 0) 
        {
            System.Console.WriteLine("Нет пересечений");
        }
        else
        {
            System.Console.WriteLine("линии идентичны");
        }
    }

    else
    {
        System.Console.WriteLine($"Точка пересечения линий y={k1}x+{b1} y={k2}x+{b2} является ({res[0]:f2}  {res[1]:f2})");
    }
}
double k1 = Promt("Введите k1 из уравнения y = k1 * x + b1: ");
double b1 = Promt("Введите b1 из уравнения y = k1 * x + b1: ");
double k2 = Promt("Введите k2 из уравнения y = k2 * x + b2: ");
double b2 = Promt("Введите b2 из уравнения y = k2 * x + b2: ");
Result(FindCross(k1, b1, k2, b2), k1, b1, k2, b2);