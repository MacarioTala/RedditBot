using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RedditMethods;

namespace RedditBot
{
    class Program
    {
        static void Main(string[] args)
        {
           var calls = new ApiCalls();
           var firstUsers = calls.GetUsers().Result;
           var redditObject = JsonConvert.DeserializeObject<RootObject>(firstUsers.ToString());
           var afterParam = redditObject.data.after;

            var redditUserList = new List<string>(); 

            foreach (var child in redditObject.data.children)
            {
                redditUserList.Add(child.data.display_name);
            }
            
            while (!string.IsNullOrEmpty(afterParam))
            {
                var nextUsers = calls.GetUsers(afterParam).Result;
                redditObject = JsonConvert.DeserializeObject<RootObject>(nextUsers.ToString());
                afterParam = redditObject.data.after;

                foreach (var child in redditObject.data.children)
                {
                    redditUserList.Add(child.data.display_name);
                }
            }
        }
    }
}
