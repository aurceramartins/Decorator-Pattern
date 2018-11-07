using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class GunClip : GunDecorator
    {
        public override int AmmoCapacity { get { return Dg.AmmoCapacity + 50; } }
        public GunClip(Gun g) : base(g)
        {
        }

        public override string Render()
        {
            return base.Dg.Render() + "Gun Clip ";
        }
    }
}
