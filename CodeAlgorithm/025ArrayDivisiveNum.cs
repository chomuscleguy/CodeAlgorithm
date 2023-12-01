using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeAlgorithm
{
    public class DivisiveNum
    {
        //문제 설명
        //array의 각 element 중 divisor로 나누어 떨어지는 값을 오름차순으로 정렬한 배열을 반환하는 함수, solution을 작성해주세요.
        //divisor로 나누어 떨어지는 element가 하나도 없다면 배열에 -1을 담아 반환하세요.

        //제한사항
        //arr은 자연수를 담은 배열입니다.
        //정수 i, j에 대해 i ≠ j 이면 arr[i] ≠ arr[j] 입니다.
        //divisor는 자연수입니다.
        //array는 길이 1 이상인 배열입니다.
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    int[] temp = new int[answer.Length + 1];

                    for (int j = 0; j < answer.Length; j++)
                    {
                        temp[j] = answer[j];
                    }
                    temp[answer.Length] = arr[i];
                    answer = temp;
                }
            }
            if (answer.Length == 0)
            {
                return new int[] { -1 };
            }
            for (int i = 0; i < answer.Length - 1; i++)
            {
                for (int j = 0; j < answer.Length - i - 1; j++)
                {
                    if (answer[j] > answer[j + 1])
                    {
                        int temp = answer[j];
                        answer[j] = answer[j + 1];
                        answer[j + 1] = temp;
                    }
                }
            }
            return answer;
        }
    }
}
