using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    //문제 설명
    //문자열 s에 나타나는 문자를 큰것부터 작은 순으로 정렬해 새로운 문자열을 리턴하는 함수, solution을 완성해주세요.
    //s는 영문 대소문자로만 구성되어 있으며, 대문자는 소문자보다 작은 것으로 간주합니다.

    //제한 사항
    //str은 길이 1 이상인 문자열입니다.
    public class StringDescendingArray
    {
        public string solution(string s)
        {
            char[] Arr = s.ToCharArray();
            string answer = "";
            
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (Arr[i] < Arr[j])
                    {
                        char temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            answer = new string(Arr);
            return answer;
        }
    }
}
