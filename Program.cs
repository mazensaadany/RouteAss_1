namespace RouteAss_1;

//the class Book initialized
class Book
{
    public string Title="refactoring";
    public int Pages=464;
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
        Console.WriteLine("_______________________________");

        #region [2nd answer]
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());
        #endregion
        Console.WriteLine("_______________________________");

        #region [3rd answer]
        //compile-time error:int cant hold string value
        //int pages = 464;
        #endregion
        Console.WriteLine("_______________________________");

        #region [4th answer]
        try
        {
            int num = 10 / 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("done");
        }
        #endregion

    }
}

