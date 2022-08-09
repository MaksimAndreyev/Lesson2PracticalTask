Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number / 10 % 10;
Console.WriteLine(secondDigit);