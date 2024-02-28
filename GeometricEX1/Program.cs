namespace GeometricEX1
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Height h = new Height();
            Width w = new Width();
            Depth d = new Depth();
            Console.WriteLine("Type the Height value:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the Width value: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the Depth value:            " + "If there´s no Depth, please press 0 and continue to show the Area Value.");
            int depth = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            h.ValueHeight = height;
            w.ValueWidth=width;
            d.ValueDepth = depth;

            if (depth==0)
            {
                Width areaValue = new Width(height, width);
                int area = areaValue.GetArea();
                Console.WriteLine("Area Value = " + area);
            }
            else
            {
                Depth volumeValue = new Depth(height, width, depth);
                int volume = volumeValue.GetVolumen();
                Console.WriteLine("Volume Value = " + volume);

            }
            int stat = Height.GetValue(h);
            Console.WriteLine($"{stat}");
            int stat1 = Width.GetValue(w);
            Console.WriteLine($"{stat1}");
            int stat2 = Depth.GetValue(d);
            Console.WriteLine($"{stat2}");

        }
    }


}
