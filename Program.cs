using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtusa_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            APICall();
        }

        public static void APICall()
        {
            int[] userIds = new int[] { 1, 3, 10 };
            Users users = new Users();
            foreach (int userId in userIds)
            {
                Console.WriteLine(users.GetUserEmailById(userId));
            }
            Console.ReadLine();
        }
        public static void StringDiff()
        {
            bool continuation = true;
            while (continuation)
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                StringDifference stringDifference = new StringDifference();
                stringDifference.FindStringDifference(str1, str2);
                Console.WriteLine();
            }
        }
    }
}



