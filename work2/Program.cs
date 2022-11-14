// найти сумму элементов от М до N, N и М заданы
Console.WriteLine("Введите число (M): ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число (N): ");
int N = int.Parse(Console.ReadLine() ?? "0");
if (M > N)
{
    Console.Write($"Невозможно, т.к. N должно быть больше M");
    return;
}
int SumRec(int k, int l)
{
    int Sum = 0; 
    if (k <= l) 
    Sum = k + SumRec(k + 1, l);
    return Sum;
}
Console.WriteLine($"Сумма элементов: {SumRec(M, N)}");