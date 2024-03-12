using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_F
{
    internal class Car
    {
        private bool engineStatus;
        private int speed;
        private int fuelLevel;
        private int fuel;

        public void StartEngine() {
            this.engineStatus = true;
        }

        public void StopEngine() {
            this.engineStatus = false;
        }

        public void Accelerator(int value) {
            this.speed += value;
            this.fuelLevel--;
        }

        public void Refue(int amount) {
            this.fuel += amount;
        }
    }
}
