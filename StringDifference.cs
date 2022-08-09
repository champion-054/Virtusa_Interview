using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtusa_Interview
{
    public class StringDifference
    {
        public void FindStringDifference(string str1, string str2)
        {
            string diff1 = FindDiff(str1, str2);
            string diff2 = FindDiff(str2, str1);
            Console.WriteLine("Output 1    Output 2");
            Console.WriteLine(diff1 + "    " + diff2);
            
        }
        private string FindDiff(string str1, string str2)
        {
            List<char> str1_charList = str1.ToList();
            List<char> str2_charList = str2.ToList();
            List<char> diffList = str1_charList.Where(x => (!str2_charList.Contains(x))).ToList();
            string diffString = "<null>";
            if(diffList != null && diffList.Count > 0)
            {
                diffString = string.Join("", diffList);
            }
            return diffString;
        }
    }
}
