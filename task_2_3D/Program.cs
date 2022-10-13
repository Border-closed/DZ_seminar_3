int F(string message)
{
Console.WriteLine(message);
int znach = int.Parse(Console.ReadLine());
return znach;
}
try
{
int A_x = F("Введите координату Х точки А");
int A_y = F("Введите координату Y точки А");
int A_z = F("Введите координату Z точки А");
int B_x = F("Введите координату Х точки B");
int B_y = F("Введите координату Y точки B");
int B_z = F("Введите координату Z точки B");
double distance = Math.Round(Math.Sqrt(Math.Pow((A_x-B_x),2)+Math.Pow((A_y-B_y),2)+Math.Pow((A_z-B_z),2)),2);
Console.WriteLine(distance);
}
catch
{
    Console.WriteLine("Вы ввили не число, а букву");
}