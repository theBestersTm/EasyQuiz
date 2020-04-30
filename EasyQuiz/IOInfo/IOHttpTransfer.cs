
using EasyQuiz.Authorization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace EasyQuiz.IOInfo
{
     class IOHttpTransfer
    {
        private static readonly HttpClient client = new HttpClient();
        
        public void DoPost(NewAdmin jsonContent) {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(NewAdmin));
            
                    string serialized = JsonConvert.SerializeObject(jsonContent);
            var json = JsonConvert.SerializeObject(jsonContent);
            var values = new Dictionary<string, string>
            {
                { "content", json }
            };
           
            HttpContent httpContent = new FormUrlEncodedContent(values);

            client.PostAsync("http://localhost:8080/user", httpContent);

        }
        

    }
}
