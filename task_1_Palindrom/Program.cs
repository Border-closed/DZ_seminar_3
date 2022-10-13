Console.WriteLine("Введите пятизначное число:   ");
string x = Console.ReadLine();
int x_length = x.Length;
if (x_length == 5)
{
int x_1 = int.Parse (x.Substring (0,2));
int x_2 = int.Parse (x.Substring (3));
int y_1 = x_1/10;
int y_2 = x_1%10;
int y_3 = x_2/10;
int y_4 = x_2%10;
if (y_1==y_4 && y_2==y_3) 
{
    Console.WriteLine("Число " + x + " полиндром");
}
else if (y_1!=y_4 && y_2!=y_3) 
{
    Console.WriteLine("Число " + x + " не полиндром");
}
else 
{
Console.WriteLine("Вы ввели не число");
}
}
else
{
    Console.WriteLine("Вы ввели не 5значное число");
}