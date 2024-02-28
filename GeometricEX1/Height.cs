namespace GeometricEX1
{
    internal class Height
    {
		protected int valueHeight;
		//PROPS
		public int ValueHeight
		{
			get { return valueHeight; }
			set { this.valueHeight = value; }
		}

		//CONSTRUCTORS
		public Height(int valueHeight)
		{
			this.valueHeight = valueHeight;
		}

		public Height()
		{
			this.valueHeight = 0;
		}

		//METHODS
		public static int GetValue(Height h)
		{
			Console.WriteLine("\nHeight Value is: ");
			return h.ValueHeight;
		}
	}
}
