namespace CodeAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DistanceNum distanceNum = new DistanceNum();

            long[] result = distanceNum.solution(2, 5);
            foreach (long num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}