using OrdiOwin.Core;
using System.Net.Http;
using System.Web.Http;

namespace OrdiOwin.Controller
{
    public class OrdiController : ApiController
    {
        private readonly ILogger _logger;
        public OrdiController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public HttpResponseMessage GetOrdi()
        {
            this._logger.Write("Inside the 'Get' method of the '{0}' controller.", GetType().Name);

            var result = "IPhone";
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, result);
        }
    }
}
