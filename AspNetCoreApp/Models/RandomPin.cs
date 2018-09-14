using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace Test.Models
{
    public class RandomPin
    {
        private List<GpioPin> _gpioPins;

        public RandomPin()
        {
            _gpioPins = new List<GpioPin>
            {
                Pi.Gpio.Pin00, Pi.Gpio.Pin01, Pi.Gpio.Pin02, Pi.Gpio.Pin03, Pi.Gpio.Pin04,
                Pi.Gpio.Pin05, Pi.Gpio.Pin06, Pi.Gpio.Pin07, Pi.Gpio.Pin08, Pi.Gpio.Pin09,
                Pi.Gpio.Pin10, Pi.Gpio.Pin11, Pi.Gpio.Pin12, Pi.Gpio.Pin13, Pi.Gpio.Pin14,
                Pi.Gpio.Pin15, Pi.Gpio.Pin16, Pi.Gpio.Pin17, Pi.Gpio.Pin18, Pi.Gpio.Pin19,
                Pi.Gpio.Pin20, Pi.Gpio.Pin21, Pi.Gpio.Pin22, Pi.Gpio.Pin23, Pi.Gpio.Pin24,
                Pi.Gpio.Pin25, Pi.Gpio.Pin26, Pi.Gpio.Pin27, Pi.Gpio.Pin28, Pi.Gpio.Pin29,
                Pi.Gpio.Pin30, Pi.Gpio.Pin31
            };
        }
        
        public int PinNo { get; set; }

        public bool UiSetPinState { get; set; }

        public void SetPinState()
        {
            var pin = _gpioPins[PinNo];
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(UiSetPinState);
        }

        public bool GetPinState
        {
            get
            {
                if (PinNo > 0 && PinNo < 32)
                {
                    var pin = _gpioPins[PinNo];
                    pin.PinMode = GpioPinDriveMode.Output;
                    return pin.Read();
                }
                else return false;
            }
        }
    }
}