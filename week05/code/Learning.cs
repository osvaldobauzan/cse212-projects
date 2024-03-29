public class Learning
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine(RecursiveSum(90));
		int b = 0;
		for(int i = 1; i <= 90; i++){
			b += i;
        }
		Console.WriteLine(b);
	}
	public static int RecursiveSum(int n, int sum = 0, int i = 1)
	{
		if(i > n)
			return sum;
		else
			return RecursiveSum(n, sum+i, i+1);
	}
}