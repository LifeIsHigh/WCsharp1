Console.Write("Enter array strings --> ");
string Arr = Convert.ToString(Console.ReadLine());
string[] Array = Arr.Split(' ');
int count = 0;
void LengArr(string[] Array)
{
    for (int i = 0; i < Array.GetLength(0) - 1; i++)
    {
        Console.Write($"{Array[i]} ");
        if (Array[i].Length <= 3)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
LengArr(Array);