using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtusa_Interview
{
    public class ApiResult
    {
        public UserInformation data { get; set; }
        public SupportInformation support { get; set; }
    }
    public class UserInformation
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }
    public class SupportInformation
    {
        public string url { get; set; }
        public string text { get; set; }
    }
    public enum APIOperationType
    {
        GET,
        POST,
        PUT
    }
}
