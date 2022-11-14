// показать натуральные числа от М до N, N и М заданы
Console.WriteLine("Введите число (M): ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число (N): ");
int N = int.Parse(Console.ReadLine() ?? "0");
if (M > N)
{
    Console.Write($"Невозможно, т.к. N должно быть больше M");
    return;
}
void Integers(int k, int l)
{
    if (k <= l)
    {
        Console.Write(k + " ");
        Integers(k + 1, l);
    }
}
Integers(M, N);