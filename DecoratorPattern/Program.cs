using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGun mg = new MachineGun(10,1);
            ShotGun sg = new ShotGun(30, 25);
            GunClip gc = new GunClip(sg);
            GunSilencer gs = new GunSilencer(gc);
            mg.Fire();
            Console.WriteLine(mg.Render());


            sg.Fire();
            Console.WriteLine(sg.Render());

            gc.Fire();
            Console.WriteLine(gc.Render());

            gs.Fire();
            Console.WriteLine(gs.Render());

        }
    }
}
