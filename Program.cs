// Посчитать колличество элеметнов в заданном отрезке массива

int [] array = new int [12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Check()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    
     if (array[i] > 9 && array[i] < 100)
     {
         count++;
     }
    }
Console.WriteLine(count);
}

PrintArray(array);
Console.WriteLine();
Check();