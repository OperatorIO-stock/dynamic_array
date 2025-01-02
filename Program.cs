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
                Console.WriteLine(numbers.Sum());
            
            if (int.TryParse(answerUser, out int number))
            {
                int[] tempNumbers = new int [numbers.Length + 1];

                for (int i = 0; i < numbers.Length; i++)
                    tempNumbers[i] = numbers[i];

                tempNumbers[tempNumbers.Length - 1] = number;

                numbers = tempNumbers;

                for (int i = 0; i < numbers.Length; i++)
                    Console.Write($"{numbers[i]} ");

                Console.WriteLine("\n");
            }
        }
    }
}
