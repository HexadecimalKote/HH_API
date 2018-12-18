using System;
using System.Collections.Generic;
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

        public List<Vacancy> JsonParseStringItems(string json)
        {
            List<Vacancy> vacancies = new List<Vacancy>();
            dynamic obj = JObject.Parse(json);

            foreach (dynamic item in obj.items)
                vacancies.Add(new Vacancy(item));

            return vacancies;
        }
    }
}
