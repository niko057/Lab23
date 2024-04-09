namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrayin uzunluqunu teyin edin:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Reqem daxil edin sonra Enter basaraq yene daxil edin Arrayin uzunluqu qeder davam edecek:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Array.Sort(numbers);
            int largestSum = numbers[size - 1] + numbers[size - 2];
            int smallestSum = numbers[0] + numbers[1];

            Console.WriteLine("En boyuk 2 ededin  cemi: " + largestSum);
            Console.WriteLine("En kicik 2 ededin cemi : " + smallestSum);

           
            Console.WriteLine("Hansi emeliyyati yerine yetirmek isteyirsiz.Adini yazin (Toplama, Cixma, Vurma, Bolme):");
            Operation selectedOperation = (Operation)Enum.Parse(typeof(Operation), Console.ReadLine(), true);

            double result = 0;

            
            switch (selectedOperation)
            {
                case Operation.Toplama:
                    result = largestSum + smallestSum;
                    break;
                case Operation.Cixma:
                    result = largestSum - smallestSum;
                    break;
                case Operation.Vurma:
                    result = largestSum * smallestSum;
                    break;
                case Operation.Bolme:
                    if (smallestSum != 0)
                    {
                        result = (double)largestSum / smallestSum;
                    }
                    else
                    {
                        Console.WriteLine("0 bolmek olmaz!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun daxil edilmedi!");
                    return;
            }

            
            Console.WriteLine("Cavab: " + result);

        }
        enum Operation
        {
            Toplama,
            Cixma,
            Vurma,
            Bolme
        }
    }
}