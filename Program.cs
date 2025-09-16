int a = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int p = 1;
int i = 1;
while (i <= m)
{
    p *= a * (a - i * n);
    i++; 
}
Console.WriteLine(p);