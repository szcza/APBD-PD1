// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
    }

    public static int Average(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return(sum / arr.Length);
        
    }
}

