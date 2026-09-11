namespace RouteAss_1;

//the class Book initialized
class Book
{
    public string Title;
    public int Pages;
}
internal class Program
{
    static void Main(string[] args)
    {
        #region [1st answer]
        Book book = new Book();
        object obj = book;

        Console.WriteLine(obj);
        #endregion
    }
}

