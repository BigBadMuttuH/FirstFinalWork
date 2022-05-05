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
        return strArray.Where(x => x.Length < 4).ToArray();
    }
}
