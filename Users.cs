using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtusa_Interview
{
    public class Users
    {
        public string GetUserEmailById(int userId)
        {
            string email = "";
            string resourceUri = "/api/users/" + Convert.ToString(userId);
            CallRestAPI callRestAPI = new CallRestAPI();
            try
            {
                ApiResult apiResult = callRestAPI.PerformAPIOperation(resourceUri, APIOperationType.GET);
                if (apiResult != null)
                {
                    email = apiResult.data.email;
                }
                else
                {
                    email = "Could not fetch email for given user id";
                }
            }
            catch (Exception)
            {
                throw new Exception("An error has occurred");
            }
            return email;
        }
    }
}
