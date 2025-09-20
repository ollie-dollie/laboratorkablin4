int a = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int p = 1;
for (int i = 1; i <= m; i++){
    p *= (a - i * n);
}
Console.WriteLine(p);



