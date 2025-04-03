namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue) : this(red, green, blue, 255) { }

        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }
        public int GetRed()
        {
            return red;
        }

        public int GetGreen()
        {
            return green;
        }

        public int GetBlue()
        {
            return blue;
        }

        public int GetAlpha()
        {
            return alpha;
        }
    }
}