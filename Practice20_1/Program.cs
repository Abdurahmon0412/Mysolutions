
int[] numbers = new int[]
{
    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
};
print(numbers);
BubbleSort(numbers);
print(numbers);

void print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}


void BubbleSort(int[] numbers)
{
    for (int sortA = 0; sortA < numbers.Length; sortA++)
    {
        for (int sortB = 0; sortB < numbers.Length; sortB++)
        {
            if (numbers[sortA] < numbers[sortB])
            {
                var temp = numbers[sortA]; numbers[sortA] = numbers[sortB]; numbers[sortB] = temp;
            }
        }
    }
}