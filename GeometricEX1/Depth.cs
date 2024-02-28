namespace GeometricEX1
{
	internal class Depth : Width
	{
		//PROPS
		protected int valueDepth;

		public int ValueDepth
		{
			get { return valueDepth; }
			set { valueDepth = value; }
		}

		//CONSTRUCTORS
		public Depth(int valueDepth, int valueWidth, int valueHeight) : base(valueHeight, valueWidth)
		{
			this.valueDepth = valueDepth;
		}

		public Depth()
		{
			this.valueDepth = 0;
		}

		//DESTRUCTOR
		~Depth()
		{

		}

		//METHODS

		public int GetVolumen()
		{
			return ValueDepth*ValueHeight*ValueWidth;
		}
        public static int GetValue(Depth d)
        {
            Console.WriteLine("\nDepth Value is: ");
            return d.ValueDepth;
        }

    }
}
