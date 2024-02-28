namespace GeometricEX1
{
    internal class Width:Height
    {
		//PROPS
		protected int valueWidth;

		public int ValueWidth	
		{
			get { return valueWidth; }
			set { valueWidth = value; }
		}

		//CONSTRUCTORS
		public Width(int valueHeight,int valueWidth):base(valueHeight)
		{
			this.valueWidth = valueWidth;
		}

		public Width()
		{
			this.valueWidth=0;
		}

		//METHODS
		public int GetArea()
		{
			return ValueWidth*ValueHeight;
		}
        public static int GetValue(Width w)
        {
            Console.WriteLine("\nWidth Value is: ");
            return w.ValueWidth;
        }

    }
}
