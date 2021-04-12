using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace wsHoldings.API
{
    public class Exchange
    {
        private string accessKey = Config.config.ACCESS_KEY;
        private string secretKey = Config.config.SECRET_KEY;
        public string getAccount()
        {
            string url = "https://api.upbit.com/v1/accounts";
            string uuid = Guid.NewGuid().ToString();
            var payload = new Dictionary<string, object>
            {
                {"access_key",accessKey },
                {"nonce", uuid }
            };
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            var token = encoder.Encode(payload, secretKey);
            var authorize_token = string.Format("Bearer {0}", token);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add(string.Format("Authorization:{0}", authorize_token));
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string result = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return result;
        }
    }
}
