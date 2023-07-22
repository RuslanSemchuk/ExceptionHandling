using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Mercedes : Car, IRadio, ISeats
    {
        public override void Breke()
        {
            speed -= 5;
            Console.WriteLine("Mercedes: Braking... Current speed: " + speed);
        }

        public override void Accelerate()
        {
            if (speed < 200)
            {
                speed += 15;
                Console.WriteLine("Mercedes: Accelerating... Current speed: " + speed);
            }
            else
            {
                throw new SpeedLimitExceededException();
            }
        }

        public void TurnOn()
        {
            Console.WriteLine("Mercedes: Turning on the radio...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Mercedes: Turning off the radio...");
        }

        public void ChangeStation()
        {
            Console.WriteLine("Mercedes: Changing the radio station...");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Mercedes: Increasing the radio volume...");
        }

        public void AdjustPosition()
        {
            Console.WriteLine("Mercedes: Adjusting the seat position...");
        }

        public void HeatOn()
        {
            Console.WriteLine("Mercedes: Turning on the seat heating...");
        }

        public void HeatOff()
        {
            Console.WriteLine("Mercedes: Turning off the seat heating...");
        }
    }
}
