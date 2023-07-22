using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
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

    public class SpeedLimitExceededException : Exception
    {
        public SpeedLimitExceededException() : base("Maximum speed reached!")
        {
        }
    }

    public class InvalidActionException : Exception
    {
        public InvalidActionException() : base("Invalid action: Cannot accelerate while moving in reverse.")
        {
        }
    }

}
