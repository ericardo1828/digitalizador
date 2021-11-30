using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizador
{
    public class convert
    {
        public string convertFileToBase64(string filePath)
        {
            byte[] AsBytes = File.ReadAllBytes(filePath);
            String AsBase64String = Convert.ToBase64String(AsBytes);

            return AsBase64String;
        }

        public string ParseNode(JObject bookJSONFile, string node)
        {
            string contentNode = null;
            //JObject store = null;
            //JObject goods = null;
            //JArray bookList = null;

            if (bookJSONFile != null && bookJSONFile[node] != null)
            {
                contentNode = (string)bookJSONFile[node];

                //store = bookJson[0];
                //goods = store["goods"];

                //if (goods["book"] != null)
                //{
                //    bookList = (JArray)goods["book"];
                //}
            }
            else
            {
                throw new Exception("File is empty, or node not found.");
            }
            return contentNode;
        }

    }

   
}
