// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] arr = { 1, 3, 6, 34, 2, 21, 12 };
        Console.WriteLine(Average(arr));
        Console.WriteLine(Max(arr));

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
    public static int Max(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return(max);
        
    }
}

