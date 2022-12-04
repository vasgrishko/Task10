int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);
int num = (randomNum % 100) / 10;
Console.WriteLine(num);

