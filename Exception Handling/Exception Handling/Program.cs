using Exception_Handling;
using System;

// Власний тип винятку для перевищення максимально допустимої швидкості
public class SpeedLimitExceededException : Exception
{
    public SpeedLimitExceededException() : base("Maximum speed reached!")
    {
    }
}

// Власний тип винятку для спроби натиснути на газ, коли автомобіль рухається заднім ходом
public class InvalidActionException : Exception
{
    public InvalidActionException() : base("Invalid action: Cannot accelerate while moving in reverse.")
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Car bmw = new Bmw();
            Car mercedes = new Mercedes();
            Car volga = new Volga();

            bmw.Accelerate();
            bmw.Breke();

            mercedes.Accelerate();
            mercedes.Breke();

            volga.Accelerate();
            volga.Breke();

            IRadio bmwRadio = (IRadio)bmw;
            ISeats bmwSeats = (ISeats)bmw;

            bmwRadio.TurnOn();
            bmwRadio.ChangeStation();
            bmwSeats.AdjustPosition();
            bmwSeats.HeatOn();
        }
        catch (SpeedLimitExceededException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (InvalidActionException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
