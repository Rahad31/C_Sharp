namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5]; 

            //Console.WriteLine("Enter five numbers:");


            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("Entered five numbers:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            int[] numbers = new int[3];

            Console.WriteLine("Enter three numbers:");


            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
            {
                Console.WriteLine("The largest number is: " + numbers[0]);
            }

            else if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
            {
                Console.WriteLine("The largest number is: " + numbers[1]);
            }
            else
            {
                Console.WriteLine("The largest number is: " + numbers[2]);
            }


            // For smallest number

            int smallestIndex;

            if (numbers[0] <= numbers[1] && numbers[0] <= numbers[2])
            { smallestIndex = 0; }

            else if (numbers[1] <= numbers[0] && numbers[1] <= numbers[2])
            { smallestIndex = 1; }

            else
            { smallestIndex = 2; }


            int smallest=0;
            switch (smallestIndex)
            {
                case 0:
                    smallest = numbers[0];
                    break;
                case 1:
                    smallest = numbers[1];
                    break;
                case 2:
                    smallest = numbers[2];
                    break;
            }

            Console.WriteLine("The smallest number is: "+smallest);
        }
    }
}
