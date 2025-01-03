namespace dynamic_array;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [];

        int quantityIndexesArray = 1;

        bool isProgramWorking = true;
        
        while (isProgramWorking)
        {
            string answerUser = Console.ReadLine();
            Console.Clear();

            if (answerUser == "exit")
            {
                isProgramWorking = false;
            }
            else if (answerUser == "sum")
            {
                Console.WriteLine($"Sum: {numbers.Sum()}");
            }
            
            if (int.TryParse(answerUser, out int number))
            {
                int[] tempNumbersData = new int [numbers.Length + quantityIndexesArray];

                for (int i = 0; i < numbers.Length; i++)
                    tempNumbersData[i] = numbers[i];

                tempNumbersData[^quantityIndexesArray] = number;

                numbers = tempNumbersData;
            }

            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]} ");

            Console.WriteLine("\n");
        }
    }
}
