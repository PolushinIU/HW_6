// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] Input(int max)
{
    int[] n = new int[max];
    for (int i = 0; i < max; i++)
    {
        n[i] = Promt($"введите {i + 1} число из {max} чисел: ");
    }
    return n;
}

int PositiveNumbers(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element > 0)
            count++;
    }
    return count;
}

int max = Promt("Сколько чисел вы хотите ввести?  ");
int [] n = Input(max);
System.Console.WriteLine($"Введено {PositiveNumbers(n)} положительных чисел ");
