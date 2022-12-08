Console.Clear();
int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}