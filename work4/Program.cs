// Написать программу, показывающую первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих. Первые 2 элемента последовательности задаются пользователем.
Console.WriteLine("Введите 1 элемент (M): ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите 2 элемент (K): ");
int K = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите общее количество чисел (N): ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[N];
if (N < 2)
{
  Console.WriteLine("N должно быть больше 2");
  return;
}
int SumRec(int N)
{
         
  if (N == 0)
  {
  return M;
  }
  if (N == 1)
  {
  return K;
  }
  if (N == 2)
  {
  return M + K;
  }
  return SumRec(N - 1) + SumRec(N - 2);
}
void PrintSumRec(int N)
{
  Console.Write($"{M}" + " ");
  Console.Write($"{K}" + " ");
  Console.Write($"{M + K}" + " ");
  for (N = 3; N < array.Length; N++)
  {
  Console.Write($"{SumRec(N - 1) + SumRec(N - 2)}" + " ");
  }
}
SumRec(N);
PrintSumRec(N);