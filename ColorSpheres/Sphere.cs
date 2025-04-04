namespace ColorSpheres
{
    public class Sphere
    {
        private float radius;
        private Color color;

        private int timesThrown;

        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            this.radius = 0;
        }

        
        public int GetTimesThrown() => timesThrown;
    }
}