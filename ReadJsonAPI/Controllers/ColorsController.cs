using ReadJsonAPI.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ReadJsonAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ColorsController : ApiController
    {
        private readonly IFileOperation _fileOperation;

        /// <summary>
        /// Contructor of class
        /// </summary>
        public ColorsController()
        {
            _fileOperation = new JsonFileOperation();
        }

        /// <summary>
        /// Async Method to get all colors from json file
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<HttpResponseMessage> GetColors()
        {
            var result = await _fileOperation.ReadFile<List<ColorExample>>();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Post method to insert record into json file
        /// </summary>
        /// <param name="ObjColorExample"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<HttpResponseMessage> PostColor(ColorExample ObjColorExample)
        {
            var result = await _fileOperation.WriteFile<ColorExample>(ObjColorExample);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }

}
