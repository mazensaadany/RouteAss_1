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
        //------------------------------------//

        #region [4th answer]
        try
        {
            int num;
            int zero = 0;

            num = 20 / zero;
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
        Console.WriteLine("_______________________________");

        #region [5th answer]
        int pages = 300;
        double D_pages = Convert.ToDouble(pages);
        #endregion
        //------------------------------------//

        #region [6th answer]
        double price = 49.99;
        int I_price = (int)price;
        #endregion
        //------------------------------------//

        #region [7th answer]
        string pagesText = "464";
        int pagesInt = Convert.ToInt32(pagesText);
        #endregion
        //------------------------------------//

        #region [8th answer] 
        string yearText = "2023";
        int yearInt = int.Parse(yearText);

        string badText = "abc";
        int badInt;
        bool flag = int.TryParse(badText, out badInt);
        if (flag)
            {
                return;
        }
        else
            {
                Console.WriteLine("Invalid number");
            }

        #endregion
        Console.WriteLine("_______________________________");

        #region [9th answer]
        int pages02 = 464;
        string pagesText02 = pages02.ToString();
        Console.WriteLine(pagesText02.GetType());
        #endregion
        Console.WriteLine("_______________________________");

      
    }
}

