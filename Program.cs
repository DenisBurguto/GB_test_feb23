
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
    array.Resize( ref outString, j);
    return outString;

}