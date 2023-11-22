using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeAlgorithm.ArrMean;

namespace CodeAlgorithm
{
    public class ArrMean
    {
        //문제 설명
        //정수 배열 numbers가 매개변수로 주어집니다.numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.

        //제한사항
        //0 ≤ numbers의 원소 ≤ 1,000
        //1 ≤ numbers의 길이 ≤ 100
        //정답의 소수 부분이 .0 또는 .5인 경우만 입력으로 주어집니다.
        public double solution(int[] numbers)
        {
            double answer = 0;
            foreach (int i in arr) answer += i;
            answer /= arr.Length;
            return answer;
        }
    }
}
