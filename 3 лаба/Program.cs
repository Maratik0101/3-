Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= x; i++)
{
    factorial = factorial * i;  
}
Console.WriteLine(factorial);