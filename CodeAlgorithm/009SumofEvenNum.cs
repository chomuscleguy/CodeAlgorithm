using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class SumofEvenNum
    {
        //문제 설명
        //정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.

        //제한사항
        //0 < n ≤ 1000
        public int solution(int n)
        {
            int answer = 0;
            if (n > 0 && n <= 1000)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        answer += i;
                    }
                }
                //자신을 포함한 짝수를 모두 더해라
            }
            return answer;
        }
    }
}
