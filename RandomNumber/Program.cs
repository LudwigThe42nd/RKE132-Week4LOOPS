Random rnd = new Random();

int myRandomNum;

int RandomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    RandomSum = RandomSum + myRandomNum;
    Console.WriteLine($"My random number is:{myRandomNum}");
}

Console.WriteLine($"random sun total:{RandomSum}");