using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace RedditMethods
{
    public class ApiCalls
    {
        //urls
        private const string BaseUrl = @"https://www.reddit.com";
        private const string UsersUrl = @"/users/.json";

        //Constants for listings
        private const string AfterQueryParameter = @"?after=";


        private async Task<JObject> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(uri);
            return await Task.Run(()=> JObject.Parse(content));
        }

        public async Task<JObject> GetUsers(string afterParameter=null)
        {
            var requestParam = BaseUrl + UsersUrl + AfterQueryParameter + afterParameter;
            var a=  GetAsync(requestParam).Result;
            return a;
        }
        
    }
}
