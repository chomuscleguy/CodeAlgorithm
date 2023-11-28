using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class DescendingOrder
    {
        //문제 설명
        //함수 solution은 정수 n을 매개변수로 입력받습니다.n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요.예를들어 n이 118372면 873211을 리턴하면 됩니다.

        //제한 조건
        //n은 1이상 8000000000 이하인 자연수입니다.
        public long solution(long n)
        {
            string num = n.ToString();
            int[] Arr = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                Arr[i] = int.Parse(num[i].ToString());
            }

            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] < Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }

            long answer = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                answer = answer * 10 + Arr[i];
            }

            return answer;
        }
    }
}
