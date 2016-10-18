using System;

class Point
{
	public double x, y;
}

class Line 
{
	public Point punct1 = new Point();
	public Point punct2 = new Point();
	public double Lung()
	{
		double l;
		l = Math.Sqrt((punct1.x-punct2.x)*(punct1.x-punct2.x)+(punct1.y-punct2.y)*(punct1.y-punct2.y));
		return l;
	}
}

class Segmdr
{
	public static void Main()
	{
		Line seg = new Line();
		Point punct1 = new Point();
		Point punct2 = new Point();
		double dist;
		seg.punct1.x = 3; seg.punct1.y = 4;
		seg.punct2.x = 5; seg.punct2.y = 3;
		// dist = Math.Sqrt((punct1.x-punct2.x)*(punct1.x-punct2.x)+(punct1.y-punct2.y)*(punct1.y-punct2.y));
		dist = seg.Lung();
		Console.WriteLine("Distanta dintre punctele ({0},{1}) si ({2},{3}) este: {4:#.##}", punct1.x, punct1.y, punct2.x, punct2.y, dist);
	}
}
