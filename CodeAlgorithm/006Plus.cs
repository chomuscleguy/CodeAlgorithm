using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class Plus
    {
        //문제 설명
        //정수 num1과 num2가 주어질 때, num1과 num2의 합을 return하도록 soltuion 함수를 완성해주세요.

        //제한사항
        //-50,000 ≤ num1 ≤ 50,000
        //-50,000 ≤ num2 ≤ 50,000
        public int solution(int num1, int num2)
        {
            int answer = -1;
            if (num1 >= -50000 && num1 <= 50000 && num2 >= -50000 && num2 <= 50000)
            {
                answer = num1 + num2;
            }
            return answer;
        }
    } 
}
