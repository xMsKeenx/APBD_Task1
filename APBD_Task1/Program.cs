namespace APBD_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            try
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    numbers[i] = int.Parse(parts[i]);
                }

                double average = StatisticsHelper.CalculateAverage(numbers);

                Console.WriteLine("Numbers loaded successfully from feature branch.");
                Console.WriteLine($"Calculated average is: {average}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter only integers.");
            }
            Console.WriteLine("Processing completed");
        }
    }
}