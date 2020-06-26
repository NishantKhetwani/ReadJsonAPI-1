using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ReadJsonAPI
{
    public class JsonFileOperation : IFileOperation
    {
        /// <summary>
        /// Reads data from json file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<T> ReadFile<T>()
        {
            using (var reader = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Colors.json")))
            {
                string json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        /// <summary>
        /// Writes data into json file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task<List<T>>WriteFile<T>(T obj)
        {
            dynamic list = null;
            using (var reader = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Colors.json")))
            {
                string json = await reader.ReadToEndAsync();
                list = JsonConvert.DeserializeObject<List<T>>(json);
                list.Add(obj);
            }
            using (var streamWriter = File.CreateText(System.Web.Hosting.HostingEnvironment.MapPath("~/Colors.json")))
            {
                string jSONString = JsonConvert.SerializeObject(list);
                streamWriter.Write(jSONString);
            }
            return list;
        }
    }
}