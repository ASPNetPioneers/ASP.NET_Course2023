namespace Structure
{
    internal struct Point
    {
        // member - static fields
        private static readonly Point _origin = new Point(x: 0, y: 0, z: 0);

        // member - Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point Origin
        {
            get
            {
                return _origin;
            }
        }
        // member - methods

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
        public void SetToOrigin()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

    }

}
