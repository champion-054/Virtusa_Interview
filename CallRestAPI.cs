using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Virtusa_Interview
{
    public class CallRestAPI
    {
        string _baseUri = "https://reqres.in/";
        public ApiResult PerformAPIOperation(string resourceURI, APIOperationType methodType)
        {
            ApiResult result = new ApiResult();
            switch (methodType)
            {
                case APIOperationType.GET:
                    result = GetOperation<ApiResult>(resourceURI).Result;
                    break;

            }
            return result;
        }
        private async Task<T> GetOperation<T>(string resourceURI)
        {
            HttpClient httpClient = GetHttpClient();
            var response = await httpClient.GetAsync(resourceURI);
            T result = default(T);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                using (HttpContent content = response.Content)
                {
                    string dataContent = content.ReadAsStringAsync().Result;
                    result = DeserializeJson<T>(dataContent);
                }
            }
            else
            {
                throw new Exception("An error occurred" + response.StatusCode);
            }
            
            return result;
        }
        private T DeserializeJson<T>(string json)
        {
            T result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }
        private HttpClient GetHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUri);
            return httpClient;
        }
    }
}
