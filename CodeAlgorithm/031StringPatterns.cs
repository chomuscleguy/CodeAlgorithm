using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class StringPatterns
    {
        //문제 설명
        //길이가 n이고, "수박수박수박수...."와 같은 패턴을 유지하는 문자열을 리턴하는 함수, solution을 완성하세요.예를들어 n이 4이면 "수박수박"을 리턴하고 3이라면 "수박수"를 리턴하면 됩니다.

        //제한 조건
        //n은 길이 10,000이하인 자연수입니다.
        public string solution(int n)
        {
            string answer = "";
            string[] Arr = new string[n];
            for (int i = 0; i < n; i += 2)
            {
                Arr[i] = "수";
            }
            for (int i = 1; i < n; i += 2)
            {
                Arr[i] = "박";
            }
            answer = string.Join("" ,Arr);
            return answer;
        }
    }
}
