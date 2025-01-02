namespace dynamic_array;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [];
        
        while (true)
        {
            string answerUser = Console.ReadLine();
            Console.Clear();

            if (answerUser == "exit")
                break;
            else if (answerUser == "sum")
                Console.WriteLine($"Sum: {numbers.Sum()}");
            
            if (int.TryParse(answerUser, out int number))
            {
                int[] tempDataNumbers = new int [numbers.Length + 1];

                for (int i = 0; i < numbers.Length; i++)
                    tempDataNumbers[i] = numbers[i];

                tempDataNumbers[^1] = number;

                numbers = tempDataNumbers;
            }

            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]} ");

            Console.WriteLine("\n");
        }
    }
}
