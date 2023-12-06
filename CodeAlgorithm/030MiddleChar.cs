using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class MiddleChar
    {
        //문제 설명
        //단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요.단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

        //재한사항
        //s는 길이가 1 이상, 100이하인 스트링입니다.
        public string solution(string s)
        {
            string answer = "";
            string Char = s.ToString();
            char[] Arr;

            if (s.Length % 2 == 0)
            {
                Arr = new char[2];
                for (int i = 0; i <= 1; i++)
                {
                    Arr[i] = Char[s.Length / 2 - 1 + i];
                }
            }
            else
            {
                Arr = new char[1];
                Arr[0] = Char[s.Length / 2];
            }
            answer = new string(Arr);
            return answer;
        }
    }
}
