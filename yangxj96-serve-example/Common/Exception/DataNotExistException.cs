namespace yangxj96_serve_example.Common.Exception;

public class DataNotExistException : System.Exception
{
    public DataNotExistException(string message) : base(message)
    {
    }
}