namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int number_copy = number;
            int sum = 0;
            int length = 0;
            while (number_copy > 0)
            {
                length++;
                number_copy /= 10;
            }
            number_copy = number;
            for (int i = 0; i < length; i++)
            {
                int mnacord = number_copy % 10;
                int pow = 1;
                for (int j = 0; j < length; j++)
                {
                    pow *= mnacord;
                }
                sum += pow;
                number_copy /= 10;
            }
            Console.WriteLine(number == sum);
        }
    }
}