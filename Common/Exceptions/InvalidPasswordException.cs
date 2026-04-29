namespace WebApplicationC__Tut101.Common.Exceptions
{
    public class InvalidPasswordException:Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
        }
    }
}
