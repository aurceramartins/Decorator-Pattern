using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }
        public abstract string Render();

        public void Fire()
        {
            Console.WriteLine("Capacity: " + AmmoCapacity + " Noise Level: " + NoiseLevel);
        }
    }
}
