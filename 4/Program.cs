int number;
int max = int.MinValue;
for(int i = 0; i < 3; i++);
number = Convert.ToInt32(Console.ReadLine());
if (max < number)
{
    max = number;
}
Console.WriteLine(max);