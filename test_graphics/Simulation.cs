//using System;

namespace test_graphics
{
    public class Simulation : IDrawable
    {
        protected List<SimulationObject> objects;
        public Simulation()
        {
            objects = new List<SimulationObject>() {

                new Animal(20, 40, 5, 1),
                new Animal(20, 60, 15, 1),
                new Plant(20, 80, 15, 15),
                new Plant(20, 100, 200, 20),
                new Meat(20, 120, 10, 1000),
                new OrganicWaste(20, 140)
            };
        }

        public void Add(SimulationObject obj)
        {
            objects.Add(obj);
        }

        public void Remove(SimulationObject obj)
        {
            objects.Remove(obj);
        }

        public void Update()
        {
            foreach (SimulationObject drawable in objects)
            {
                drawable.Update(this);
            }
        }

        public List<SimulationObject> getList() { return objects; }


        public void Draw(ICanvas canvas, RectF dirtyRect)
        { 
            foreach (SimulationObject drawable in objects)
            {
                canvas.FillColor = drawable.Color;
                canvas.FillCircle(new Point(drawable.X, drawable.Y), 5.0);
            }
        }
    }
}

