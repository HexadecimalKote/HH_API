using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadHunterLibrary
{
    public class HHModel
    {
        /// <summary>
        /// Получение ответа на GET запрос
        /// </summary>
        /// <param name="request">URL запроса</param>
        /// <returns></returns>
        public string GetRequest(string request)
        {
            string tmp = "";

            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Chrome");
                Stream stream = client.OpenRead(request);

                StreamReader sr = new StreamReader(stream);

                string line;

                while ((line = sr.ReadLine()) != null)
                    tmp += line;

                sr.Close();
            }
            catch (Exception e)
            {
                tmp = e.Message;
            }

            return tmp;
        }

        public string JsonParseString(string json)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(json);

            tmp += obj.name + Environment.NewLine;
            tmp += "Зарплата от: " + obj.salary.from + "  до: " +
                                     obj.salary.to + " " +
                                     obj.salary.currency + Environment.NewLine;

            return tmp;
        }

        public string JsonParseStringItems(string json)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(json);

            foreach (dynamic item in obj.items)
            {
                tmp += item.id + Environment.NewLine;
                tmp += item.name + Environment.NewLine;

                if (item.salary != null)
                    tmp += "Зарплата от: " + item.salary.from + "  до: " +
                                                item.salary.to + " " +
                                                item.salary.currency + Environment.NewLine;
                else
                    tmp += "Зарплата: данные отсутствуют" + Environment.NewLine;

                tmp += new string('=', 20) + Environment.NewLine;
            }

            return tmp;
        }
    }
}
