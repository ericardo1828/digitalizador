using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizador
{
    public class rest
    {

        

        private void GetItems()
        {
            var url = $"https://services-dev.iepcjalisco.org.mx:8443/api/v1/casilla/tlaquepaque";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                            //Console.WriteLine(responseBody);

                            //List<Casilla> CasillasList = JsonConvert.DeserializeObject<List<Casilla>>(responseBody);

                            JObject SearchNode = JObject.Parse(responseBody);

                            // Obtener la propiedades result en una lista 
                            IList<JToken> results = SearchNode["data"].Children().ToList();

                            // Serializa resultados JSON a un objeto .NET
                            IList<cCasilla> searchResults = new List<cCasilla>();

                            foreach (JToken result in results)
                            {
                                cCasilla searchResult = JsonConvert.DeserializeObject<cCasilla>(result.ToString());
                                searchResults.Add(searchResult);
                            }

                            //if (searchResults != null && searchResults.Count > 0)
                            //{
                            //    dataGridView1.DataSource = searchResults;
                            //    dataGridView1.Refresh();
                            //}

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }

        public static string PostItem(string data)
        {
            var url = $"https://services-dev.iepcjalisco.org.mx:8443/api/v1/login";
            var request = (HttpWebRequest)WebRequest.Create(url);
            //string json = $"{{\"data\":\"{data}\"}}";
            string json = data;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            return responseBody;


                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                return "error";
            }
        }

        public static string PostItemFile64(string data,string param_url)
        {
            /*var url = $"https://imgsrv.iepcjalisco.org.mx/catd/imagenprep";*/
            var url = param_url;
            var request = (HttpWebRequest)WebRequest.Create(url);
            //string json = $"{{\"data\":\"{data}\"}}";
            string json = data;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            return responseBody;


                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                return "error";
            }
        }

        /// <summary>
        /// Post for a REST api
        /// </summary>
        /// <param name="token">authorization token</param>
        /// <param name="url">REST url for the resource</param>
        /// <param name="content">content</param>
        /// <returns>response from the rest url</returns>
        public async Task<JObject> PostAsync(string token, string url, string content)
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + token);
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                WebResponse response = await request.GetResponseAsync();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseContent = reader.ReadToEnd();
                    JObject adResponse =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
                    return adResponse;
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
                    {
                        string responseContent = reader.ReadToEnd();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
                    }
                }
            }

            return null;
        }
    }
}
