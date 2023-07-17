using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Bmw : Car, ISeats, IRadio
    {
        public override void Breke()
        {
            speed -= 10;
            Console.WriteLine("Bmw: Braking... Current speed: " + speed);
        }

        public override void Accelerate()
        {
            if (speed < 250)
            {
                speed += 20;
                Console.WriteLine("Bmw: Accelerating... Current speed: " + speed);
            }
            else
            {
                throw new Exception("Bmw: Maximum speed reached!");
            }

             void TurnOn()
            {
                Console.WriteLine("Bmw: Turning on the radio...");
            }

             void TurnOff()
            {
                Console.WriteLine("Bmw: Turning off the radio...");
            }

             void ChangeStation()
            {
                Console.WriteLine("Bmw: Changing the radio station...");
            }

             void IncreaseVolume()
            {
                Console.WriteLine("Bmw: Increasing the radio volume...");
            }

             void AdjustPosition()
            {
                Console.WriteLine("Bmw: Adjusting the seat position...");
            }

             void HeatOn()
            {
                Console.WriteLine("Bmw: Turning on the seat heating...");
            }

             void HeatOff()
            {
                Console.WriteLine("Bmw: Turning off the seat heating...");
            }
        }

        public void AdjustPosition()
        {
            throw new NotImplementedException();
        }

        public void HeatOff()
        {
            throw new NotImplementedException();
        }

        public void HeatOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void ChangeStation()
        {
            throw new NotImplementedException();
        }

        public void IncreaseVolume()
        {
            throw new NotImplementedException();
        }
    }
}
