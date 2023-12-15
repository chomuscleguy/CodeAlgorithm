using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    //문제 설명
    //자연수 n이 매개변수로 주어집니다.n을 3진법 상에서 앞뒤로 뒤집은 후, 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.

    //제한사항
    //n은 1 이상 100,000,000 이하인 자연수입니다.
    public class ReverseBase3
    {
        public int solution(int n)
        {
            int answer = 0;
            string Base3 = "";
            while (n > 0)
            {
                int remainder = n % 3;
                Base3 = Base3 + remainder.ToString();
                n /= 3;
            }

            for (int i = 0; i < Base3.Length; i++)
            {
                answer += int.Parse(Base3.Substring((Base3.Length - 1) - i, 1)) * (int)Math.Pow(3, i);
            }
            return answer;
        }
    }
}
