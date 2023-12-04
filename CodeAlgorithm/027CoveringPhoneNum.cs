using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlgorithm
{
    public class CoveringPhoneNum
    {
        public string solution(string phone_number)
        {
            string answer = "";  
            string num = phone_number.ToString();
            char[] Arr = new char[phone_number.Length];
            if (phone_number.Length >= 4)
            {
                for (int i = 0; i < phone_number.Length; i++)
                {
                    if (phone_number.Length - 4 <= i)
                    {
                        Arr[i] = phone_number[i];
                    }
                    else Arr[i] = '*';
                }
            }
            answer = new string(Arr);
            return answer;
        }
    }
}
