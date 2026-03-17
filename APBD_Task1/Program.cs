namespace APBD_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string? input = Console.ReadLine();

            string[] parts = input!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("Numbers loaded successfully.");
        }
    }
}