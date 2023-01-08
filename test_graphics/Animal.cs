using System;
namespace test_graphics
{
    public class Animal : Organism
    {
        public Animal(double x, double y, double lifetime, double energy) : base(Colors.Black, x, y, lifetime, energy) {}


        //METHODS
        public override void Update(Simulation obj)
        {
            X += 2;

            if (obj.getList().Contains(this))  //not dead yet
            {
                //aging
                if (!this.lifetimeUpdated())
                {
                    this.Transform(obj, this);
                }
            }
        }
        private bool lifetimeUpdated()
        {
            Energy--;
            if (Energy == 0)
            {
                if (this.Lifetime > 0)
                {
                    Energy = this.Lifetime;
                    this.Lifetime--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

