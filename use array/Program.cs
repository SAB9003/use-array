// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Random random = new Random();
int[] arrey = new int[10];
int sum = 0;
for(int i=0;i < 10; i++)
{
    arrey[i] = random.Next(-10, 11);
    sum += arrey[i];
}
foreach (int item in arrey)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    //якщо разувати що 0 індекс це парне число
    if (!(i % 2 == 0))
        Console.Write($"{arrey[i]} ");
    //якщо разувати що 0 індекс це не парне число
    //if (i % 2 == 0)
    //    Console.Write($"{arrey[i]} ");
}
Console.WriteLine();
if (sum < 0)
    Console.WriteLine($"The sum of the numbers in the array is less than 0: {sum } < 0");
else if (sum > 0)
    Console.WriteLine($"The sum of the numbers in the array is greater than 0: {sum} > 0");
else
    Console.WriteLine("The sum of the numbers in the array is equal to 0");