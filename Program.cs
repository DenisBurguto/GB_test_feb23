// method get string array and return string array with length of element <= definite length 
string[] GetArrayWithElementsNeededLength(string[] array, int elementLength)
{
    string[] outString = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLength)
        {
            outString[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref outString, j);
    return outString;
}
//  method ask user to input string array from console
string[] GetStringArrayFromConsole()
{
    Console.WriteLine("Please help us to create string array.");
    int arraySize = 0;
    do
    {
        Console.Write("Please input string array length: ");
        bool pars = int.TryParse(Console.ReadLine(), out int i);
        if (pars != true || i <= 0) Console.WriteLine("Incorrect input");
        arraySize = i;
    }
    while (arraySize <= 0);

string[] array = new string[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.Write($"Please input string array element with index {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Thanks for your help! Array created.");
return array;
}

// here we use above methods and return array with elements with length less or equal 3.
string[] start = GetStringArrayFromConsole();
Console.WriteLine( "Just for your ref., your array is:" + "[" + String.Join(", ", start) + "]");

string[] test = GetArrayWithElementsNeededLength(start, 3);
Console.WriteLine("We will return new array composed from your's with element's length <=3.");
Console.WriteLine( "So, new array is:" + "[" + String.Join(", ", test) + "]");
