
namespace test_graphics
{
    abstract public class Organism : SimulationObject    //everything that is alive
    {
        //ATTRIBUTES
        protected Double lifetime;
        protected Double energy;


        //CONSTRUCTOR
        public Organism(Color color, Double x, Double y, double lifetime, double energy) : base(color, x, y)
        {
            this.lifetime = lifetime;
            this.energy = energy;
            this.X = x;
            this.Y = y;
        }


        //METHODS

        protected void Transform(Simulation objects, SimulationObject obj)
        {
            try
            {
                if (obj is Plant) //organism is plant
                {
                    objects.Add(new OrganicWaste(obj.X, obj.Y));   //turn into organic waste
                }
                else  //organism is animal
                {
                    objects.Add(new Meat(obj.X, obj.Y, 20, 50 + energy));  //turn into Meat
                }
                objects.Remove(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        //ACCESSORS
        public Double Lifetime { get { return this.lifetime; } set { this.lifetime = value; } }
        public Double Energy { get { return this.energy; } set { this.energy = value; } }
    }
}
