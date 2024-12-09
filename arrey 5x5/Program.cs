// See https://aka.ms/new-console-template for more information
int size = 5,max,min;
int[,] arrey = new int[size, size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        arrey[i, j] = random.Next(-100, 101);
    }
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{arrey[i, j],4}");
    }
    Console.WriteLine();
}
Dictionary<string, int> max_and_min_number = new Dictionary<string, int>();
max_and_min_number.Add("max_x", 0);
max_and_min_number.Add("max_y", 0);
max_and_min_number.Add("min_x", 0);
max_and_min_number.Add("min_y", 0);
max = arrey[0, 0];
min = arrey[0, 0];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (max < arrey[i, j])
        {
            max = arrey[i, j];
            max_and_min_number["max_x"]=i;
            max_and_min_number["max_y"] = j;
        }
        if (min > arrey[i, j])
        {
            min = arrey[i, j];
            max_and_min_number["min_x"] = i;
            max_and_min_number["min_y"] = j;
        }
    }
}
Console.WriteLine($"The largest number is {max}, its coordinates: x = " +
    $"{max_and_min_number["max_x"]+1} y = {max_and_min_number["max_y"]+1}");
Console.WriteLine($"The smallest  number is {min}, its coordinates: x = " +
    $"{max_and_min_number["min_x"] + 1} y = {max_and_min_number["min_y"] + 1}");