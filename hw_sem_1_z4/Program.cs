Console.Write("Введите число: ");
int count = 1;
for (int N = Convert.ToInt32(Console.ReadLine()); count != N + 1; count++)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
}
