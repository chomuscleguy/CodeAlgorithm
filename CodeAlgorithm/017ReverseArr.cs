using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class ReverseArr
    {
        public int[] solution(long n)
        {
            string num = n.ToString();
            int[] answer = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                answer[i] = int.Parse(num.Substring((num.Length -1) -i, 1));
            }
            return answer;
        }
    }
}
