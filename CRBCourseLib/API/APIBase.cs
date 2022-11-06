using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Xml.Serialization;
using CRBCourseLib.Model;

namespace CRBCourseLib.API
{
    internal class APIBase : IAPIBase
    {
        private readonly String _apiUrl;

        internal APIBase(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public T Get<T>(string endpoint, string queryParams = null)
        {
            var cbrReqUri = new UriBuilder(_apiUrl+endpoint);

            if (queryParams != null)
            {
                cbrReqUri.Query = queryParams;
            }

            using(var client = new HttpClient())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                
                var response = client.GetAsync(cbrReqUri.Uri).Result;

                using (StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result, Encoding.Default))
                {
                     return (T) xmlSerializer.Deserialize(reader);
                }

            }
        }
    }
}
