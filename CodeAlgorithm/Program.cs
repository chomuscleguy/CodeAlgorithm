namespace CodeAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReverseArr reverseArr = new ReverseArr();

            int[] result = reverseArr.solution(1234);

            foreach (long num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}