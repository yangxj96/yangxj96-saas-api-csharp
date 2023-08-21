namespace yangxj96_serve_example.Common.Exception;

public class DataExistException : System.Exception
{
    public DataExistException(string message) : base(message)
    {
    }
}