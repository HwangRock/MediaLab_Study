string[] num = Console.ReadLine().Split();

int year = int.Parse(num[0]);

if (year % 4==0 && (year % 400 == 0 || year % 100 != 0))
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}
