using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class Quotient
    {
        //문제 설명
        //정수 num1, num2가 매개변수로 주어질 때, num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.

        //제한사항
        //0 < num1 ≤ 100
        //0 < num2 ≤ 100
        public int solution(int num1, int num2)
        {
            int answer = 0;
            if (num1 >= 0 && num1 <= 100 && num2 >= 0 && num2 <= 100)
            {
                answer = num1 / num2;
            }
            return answer;
        }
    }
}
