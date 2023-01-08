using System;
namespace test_graphics
{
    public class Meat : SimulationObject
    {
        //after some time, the meat rots and becomes organic waste
        protected Double lifetime;
        protected Double energy;

        public Meat(double x, double y, double lifetime, double energy) : base(Colors.Red, x, y) {

            this.lifetime = lifetime;
            this.energy = energy;
        }

        public override void Update(Simulation objects)
        {
            if (this.lifetime>0) { 
                this.lifetime--; 
            }
            else { 
                this.Transform(objects); 
            }
        }

        private void Transform(Simulation objects)
        {
            objects.Add(new OrganicWaste(this.X, this.Y));   //turn into organic waste
            objects.Remove(this);
        }
    }
}

