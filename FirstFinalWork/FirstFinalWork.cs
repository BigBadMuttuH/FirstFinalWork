public static class FirstFinalWork
{
    public static void Main(string[] args)
    {
        string[] s1 = {"hello", "2", "world", ":-)"}; //-> ["2", ":-)"]
        string[] s2 = Get3CharsStrinArray(s1);
        Console.WriteLine(String.Join(' ', s2));
    }

    /// <summary>
    /// Возвращает массив элементов, длина которых меньше или равна 3 символам
    /// </summary>
    /// <param name="strArray"></param>
    /// <returns> string[] </returns>
    public static string[] Get3CharsStrinArray(string[] strArray)
    {
        // все можно решить в одну строчку:
        // return strArray.Where(x => x.Length < 4).ToArray();
        // но тут у меня возникли сложности с написанием алгоритма :(
        // по этому пришлось переписывать в соответсвии с алгоритомт :)

        if (strArray == null) return new string[0];

        int size = strArray.Length;
        int i = 0, counter = 0;

        while (i < size)
        {
            if (strArray[i].Length < 4)
            {
                counter++;
            }
            i++;
        }

        if (counter == 0) return new string[0];

        string[] outString = new string[counter];
        i = 0;
        counter = 0;

        while (i < size)
        {
            if (strArray[i].Length < 4)
            {
                outString[counter] = strArray[i];
                counter++;
            }
            i++;
        }

        return outString;
    }
}
