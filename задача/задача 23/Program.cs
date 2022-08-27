Console.WriteLine("Введите  число n ");
double n = double.Parse(Console.ReadLine());
double i = 1;
double y = 3;
Console.Write(n+"-> ");
n=Math.Abs(n);
while (i<=n)
{
Console.Write(Math.Pow(i, y) + ",");
i++;
}
