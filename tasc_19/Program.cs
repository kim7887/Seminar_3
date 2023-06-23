// Задача 19: Напишите программу, которая
// принимает
// на вход пятизначное число и проверяет, является
// ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool fl = true;

int Number_of_Digits(int number)
{
    int t = 0;
    while (number != 0)
    {
        t++;
        number = number / 10;
    }
    return t;
}

bool Palindrome_Check(int number)
{
    int t = 0, len = Number_of_Digits(number);
    bool result = true;
    while (t != len / 2)
    {
        int begin = number / (int)Math.Pow(10, len - t - 1) % 10, end = number / (int)Math.Pow(10,t) % 10;
        //Console.WriteLine($"digit {t}, {begin}, {end}"); -- Tracing
        if (begin != end)
        {
            result = false;
            break;
        }
        t++;
    }
    return result;
}
int r = GetObj("Provide an integer ten to infinity");
fl = Palindrome_Check(r);
Console.WriteLine($"Checked if palindrome: {fl}, with digit number of {Number_of_Digits(r)}");