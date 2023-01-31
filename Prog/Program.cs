void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}

int FilterArray(string[] input, string[] output, int maxlength)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxlength )
        {
            if (output != null) output[count] = input[i];
            count++;
        }
    }
    return count;
}
string[] input = {"1", "12", "123", "1234", "12345", 
                  "a", "ab", "abc", "abcd", "abcde", "abcdef"};
                  
Console.WriteLine("Исходный массив:");
PrintArray(input);
string[] output = new string[FilterArray(input, null, 3)];
FilterArray(input, output, 3);
Console.WriteLine("Конечный массив:");
PrintArray(output);
