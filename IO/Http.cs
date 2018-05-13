using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IO {
    static class Http {
        
        public static T Get<T>(string address) {
            var request = WebRequest.Create(address);
            var response = (HttpWebResponse)request.GetResponse();
            return JsonConvert.DeserializeObject<T>(new StreamReader(response.GetResponseStream()).ReadToEnd());
        }
    }
}
