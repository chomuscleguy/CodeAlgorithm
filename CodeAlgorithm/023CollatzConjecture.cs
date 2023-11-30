using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class CollatzConjecture
    {
        public int solution(long num)
        {
            int answer = 0;
            int i = 0;
            while (i < 500)
            {
                
                if (num != 1)
                {
                    i++;
                    if (num % 2 == 0)
                    {
                        num /= 2;
                    }
                    else num = (num * 3) + 1;
                }
                else 
                {
                    answer = i;
                    break;
                }
            }
            if(i>=500)
            {
                answer = -1;
            }
            return answer;
        }
    }
}
