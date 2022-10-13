Console.WriteLine("Введите число");
try
{
double N = double.Parse(Console.ReadLine());
double start = 1;
while (start < N+1)
{
    double x = Math.Pow(start,3);
    Console.Write(x + ", ");
    start++;
}
}
catch
{
    Console.WriteLine("Вы ввели не число");
}