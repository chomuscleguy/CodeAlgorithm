using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeAlgorithm.DotProduct;

namespace CodeAlgorithm
{
    public class StrangeCharacters
    {
        //문제 설명
        //문자열 s는 한 개 이상의 단어로 구성되어 있습니다.각 단어는 하나 이상의 공백문자로 구분되어 있습니다. 각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수, solution을 완성하세요.

        //제한 사항
        //문자열 전체의 짝/홀수 인덱스가 아니라, 단어(공백을 기준) 별로 짝/홀수 인덱스를 판단해야합니다.
        //첫 번째 글자는 0번째 인덱스로 보아 짝수번째 알파벳으로 처리해야 합니다.
        public string solution(string s)
        {
            string answer = "";
            string[] split = s.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                char[] Arr = split[i].ToCharArray();
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        answer += Arr[j].ToString().ToUpper();
                    }
                    if (j % 2 == 1)
                    {
                        answer += Arr[j].ToString().ToLower();
                    }
                }
                if (i < split.Length - 1)
                {
                    answer += ' ';
                }
            }
            return answer;
        }
    }
}
