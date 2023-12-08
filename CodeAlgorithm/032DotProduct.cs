using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    internal class DotProduct
    {
        //문제 설명
        //길이가 같은 두 1차원 정수 배열 a, b가 매개변수로 주어집니다.a와 b의 내적을 return 하도록 solution 함수를 완성해주세요.

        //이때, a와 b의 내적은 a[0]* b[0] + a[1]* b[1] + ... + a[n - 1]* b[n-1] 입니다. (n은 a, b의 길이)

        //제한사항
        //a, b의 길이는 1 이상 1,000 이하입니다.
        //a, b의 모든 수는 -1,000 이상 1,000 이하입니다.
        public class Solution
        {
            public int solution(int[] a, int[] b)
            {
                int sum = 0;
                int answer = 1234567890;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i] * b[i];
                }
                answer = sum;
                return answer;
            }
        }
    }
}
