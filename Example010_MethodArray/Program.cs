int[] array = {5, 7, 9, 88, 15};
int n = array.Length;
int find = 88;
int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Index:" + index);
        break;
    }
    index++;
}