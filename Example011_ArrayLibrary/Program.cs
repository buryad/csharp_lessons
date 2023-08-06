void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col )
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];


int IndexOf(int find, int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;
    while(index < length)
    {
        if (collection[index] == find)
        {
            //Console.WriteLine("Index:" + index);
            //break;
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int FindMax(int[] collection)
{
    int result = collection[0];
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if (result < collection[index])
        {
            result = collection[index];
        }
        index++;
    }
    return result;
}

FillArray(array);
PrintArray(array);
int max = FindMax(array);
Console.WriteLine("max=" + max);
int pos = IndexOf(777,array);
Console.WriteLine("pos=" + pos);
