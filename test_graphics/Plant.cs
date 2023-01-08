using System;
namespace test_graphics
{
    public class Plant : Organism
    {

        public Plant(double x, double y, double lifetime, double energy) : base(Colors.Green, x, y, lifetime, energy) {
            this.lifetime = lifetime;
            this.energy = energy;
        }

        public override void Update(Simulation obj)
        {
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

