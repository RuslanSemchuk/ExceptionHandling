public class InvalidActionException : Exception
{
    public InvalidActionException() : base("Invalid action: Cannot accelerate while moving in reverse.")
    {
    }
}
