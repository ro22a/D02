namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Number of small carpets: ");
			int numOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Number of large carpets: ");
			int numOfLargeCarpets = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(">>Estimate for carpet cleaning service<<");
			Console.WriteLine($"Number of small carpets: {numOfSmallCarpets} ");
			Console.WriteLine($"Number of large carpets: {numOfLargeCarpets} ");
			Console.WriteLine("Price per small room: $25");
			Console.WriteLine("Price per large room: $35");
			int cost = (numOfSmallCarpets * 25) + (numOfLargeCarpets * 35);
			Console.WriteLine($"Cost: ${cost}");
			double tax = cost * 0.06;
			Console.WriteLine($"Tax: ${tax}");
			Console.WriteLine("============================================");
			Console.WriteLine($"Total estimate: ${cost + tax}");
			Console.WriteLine("This estimate is valid for 30 days");
		}
	}
}