using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ANAFquery
{
    public class ANAFquery
    {
        const string anafLink = "https://webservicesp.anaf.ro/PlatitorTvaRest/api/v3/ws/tva";

        public void SendRequestForOneItem(QueryItem q, out string strFound, out string strNotFound)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(anafLink);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                string json = "[ " + JsonConvert.SerializeObject(q, Formatting.Indented) + " ]";

                var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                string result;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                dynamic response = JsonConvert.DeserializeObject(result);

                strFound = response.found.ToString();
                strFound = strFound.Remove(0, 1);
                strFound = strFound.Remove(strFound.Length - 1, 1);

                strNotFound = response.notfound.ToString();
                strNotFound = strNotFound.Remove(0, 1);
                strNotFound = strNotFound.Remove(strNotFound.Length - 1, 1);
            }
            catch (Exception ex)
            {
                strFound = ex.ToString();
                strNotFound = ex.ToString();
            }
        }

        public void SendRequestForListItem(List<QueryItem> q, out string strFound, out string strNotFound)
        {
            try
            {
                //TODO: de validat ca q are mai putin de 500 de elemente
                if(q.Count >= 500)
                {
                    strFound = "Numar prea mare de elemente. (max < 500)";
                    strNotFound = "Numar prea mare de elemente. (max < 500)";

                    return;
                }

                //TODO: conectare la server
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(anafLink);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                //TODO: de construit json pentru trimis la server
                string json = JsonConvert.SerializeObject(q, Formatting.Indented);

                //TODO: de trimis json la server
                var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                //TODO: de primit raspunsul de la server + deserializare
                string result;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                dynamic response = JsonConvert.DeserializeObject(result);

                //TODO: de scris in parametri de out

                strFound = response.found.ToString();
                strFound = strFound.Remove(0, 1);
                strFound = strFound.Remove(strFound.Length - 1, 1);

                strNotFound = response.notfound.ToString();
                strNotFound = strNotFound.Remove(0, 1);
                strNotFound = strNotFound.Remove(strNotFound.Length - 1, 1);
            }
            catch (Exception ex)
            {
                strFound = ex.ToString();
                strNotFound = ex.ToString();
            }

        }




    }
}
