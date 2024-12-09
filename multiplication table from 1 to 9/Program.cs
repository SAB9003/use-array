// See https://aka.ms/new-console-template for more information
int size = 9;
int[,] arrey = new int[size,size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        arrey[i,j] = (i+1) * (j+1);
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{arrey[i,j],3}");
    }
    Console.WriteLine();
}