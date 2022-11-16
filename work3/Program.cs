// Написать программу вычисления функции Аккермана
Console.WriteLine("Введите число (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    if (m > 0 && n == 0) return A(m - 1, 1);
    return A(m, n);
}
Console.WriteLine(A(m, n));